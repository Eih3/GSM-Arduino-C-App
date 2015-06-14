#include "SIM900.h"
#include "sms.h"
#include "SoftwareSerial.h"

SMSGSM sms;

boolean started;
char smsbuffer[160];
char n[20];
boolean cSharpApp;

void setup()
{
  Serial.begin(9600);
  Serial.print("Attente de connexion GSM ... ");

  if (gsm.begin(2400))
  {
    Serial.println("SUCCESS");
    started = true; 
  }
  else Serial.println("FAILED");
  
  if (started) 
  {
    Serial.println("Suppression SMS existant ...");
    eraseSMS();
   }
}

void loop()
{
  if (Serial.available() > 0)
  {
    char serialRx = Serial.read();
    
    switch (serialRx)
    {
      case '#':
        cSharpApp = true;
        break;
      case 'A':
        cSharpApp = false;
        Serial.println("\nCommunication Arduino");
        break;
    }  
  }
  
  int pos=0;
  
  if (started)
  {
    pos = sms.IsSMSPresent(SMS_ALL);
    
    if (pos)
    {      
      sms.GetSMS(pos, n, smsbuffer, 100);
      affichageSMS();      
      eraseSMS(); 
    }
  }
}

void eraseSMS()
{
  for (int i = 0; i < 10; i++)
  {
    int pos = sms.IsSMSPresent(SMS_ALL);
    
    if (pos != 0)
    {      
      if (sms.DeleteSMS(pos) == 1) Serial.println("Suppression SMS " + (String)pos + " SUCCESS");      
      else Serial.println("Supppression SMS " + (String)pos + " FAILED");     
    }
  } 
  
  delay(500);
      
  Serial.println("Attente SMS  ...");
}

void affichageSMS()
{
  if (cSharpApp == true)
  {
    Serial.println("|" + (String)n + (String)smsbuffer);
    } else
    {
  Serial.println("\nNouveau SMS recu : ");
  Serial.println("NUMERO : " + (String)n);
  Serial.println("MESSAGE : " + (String)smsbuffer);
  }
}
