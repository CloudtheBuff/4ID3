
#include "L01.h"

void setup(){

  //Start the serial monitor at 115200 baud
  Serial.begin(115200); 

  //Create a sensor object that is passed into the getSensor method of the dht class
  //Only the dht sensor requires this
  sensor_t sensor;
  dht.temperature().getSensor(&sensor);
  dht.humidity().getSensor(&sensor);

  //Run the begin()method on each sensor to start communication
  dht.begin();
  bmp.begin();
  BH1750.begin(BH1750_TO_GROUND);   

  //Start the WiFi driver and tell it to connect to your local network
  //WiFi.mode(WIFI_STA);
  WiFi.begin(ssid, pass);

  //While it is connecting, print a '.' to the serial monitor every 500 ms
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }

  //Once connected, print the local IP address
  Serial.println("");
  Serial.println("WiFi connected");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());

  //Set the MQTT client to connect to the desired broker
  client.setServer(brokerAddress, 1887);
  
}

void reconnect() {

  //While the client remains unconnected from the MQTT broker, attempt to reconnect every 2 seconds
  //Also, print diagnostic information
  while (!client.connected()) {
    Serial.print("\nAttempting MQTT connection...");
  
    if (client.connect("ESP8266Client")) {
      Serial.println("Connected to MQTT server");  
      client.subscribe("testTopic");
    } else {
      Serial.print("\nFailed to connect to MQTT server, rc = ");
      Serial.print(client.state());
      delay(2000);
    }
  }
}


void loop(){

  //Polling the DHT and BMP sensor using events
  sensors_event_t dhtEvent, bmpEvent;
  dht.temperature().getEvent(&dhtEvent);
  dht.humidity().getEvent(&dhtEvent);
  bmp.getEvent(&bmpEvent);

  //Polling the BH sensor
  BH1750.start(); 
  float lux=BH1750.getLux(); 

  //Printing sensor readings to serial monitor
   Serial.println("\n-");
  (!isnan(dhtEvent.temperature)) ? Serial.println("Temperature: " + String(dhtEvent.temperature) + " degC") : Serial.println("Temperature Sensor Disconnected");
  
  (!isnan(dhtEvent.relative_humidity)) ? Serial.println("Humidity: " + String(dhtEvent.relative_humidity) + " %") : Serial.println("Humidity Sensor Disconnected");

  (!isnan(bmpEvent.pressure)) ? Serial.println("Pressure: " + String(bmpEvent.pressure) + " hPa") : Serial.println("Pressure Sensor Disconnected");

  (!isnan(lux)) ? Serial.println("Light Intensity: " + String(lux) + " lux") : Serial.println("Lux Sensor Disconnected");

  //If the client disconnects from the MQTT broker, attempt to reconnect
  if (!client.connected()) {
    reconnect();
  }
  if(!client.loop())
    client.connect("ESP8266Client");

  //Publish the sensor data to the associated topics
  client.publish("4ID3_G7/temperature", String(dhtEvent.temperature).c_str());
  delay(100);
  client.publish("4ID3_G7/humidity", String(dhtEvent.relative_humidity).c_str());
  delay(100);
  client.publish("4ID3_G7/pressure", String(bmpEvent.pressure).c_str());
  delay(100);
  client.publish("4ID3_G7/light", String(lux).c_str());
  
  delay(DELAY_BETWEEN_SAMPLES_MS);
}
