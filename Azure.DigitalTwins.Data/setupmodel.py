from azure.identity import ClientSecretCredential
from azure.digitaltwins.core import DigitalTwinsClient

# Replace these with your actual values
tenant_id = ""
client_id = ""
client_secret = ""
adt_instance_url = ""

# Authenticate using ClientSecretCredential
credential = ClientSecretCredential(tenant_id, client_id, client_secret)
client = DigitalTwinsClient(adt_instance_url, credential)

# Define the room model
room_model = {
    "@id": "dtmi:example:Room;1",
    "@type": "Interface",
    "@context": "dtmi:dtdl:context;2",
    "displayName": "Room",
    "contents": [
        {
            "@type": "Property",
            "name": "Temperature",
            "schema": "double"
        },
        {
            "@type": "Property",
            "name": "Humidity",
            "schema": "double"
        }
    ]
}

# Define the relationship model
relationship_model = {
    "@id": "dtmi:example:ConnectedTo;1",
    "@type": "Interface",
    "@context": "dtmi:dtdl:context;2",
    "displayName": "ConnectedTo",
    "contents": [
        {
            "@type": "Relationship",
            "name": "connectedTo",
            "target": "dtmi:example:Room;1",
            "properties": []
        }
    ]
}

# Upload the models
client.create_models([room_model, relationship_model])

print("Models uploaded successfully.")
