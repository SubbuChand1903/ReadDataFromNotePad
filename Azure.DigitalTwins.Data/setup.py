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

# Create and upsert 10 twins
for i in range(1, 11):
    twin_id = f"myTwin{i}"
    twin_data = {
        "$dtId": twin_id,
        "$metadata": {
            "$model": "dtmi:example:Room;1"  # Ensure this model exists
        },
        "Temperature": 20 + i,
        "Humidity": 50 + i
    }
    
    # Upsert the twin
    client.upsert_digital_twin(twin_id, twin_data)
    print(f"Twin {twin_id} upserted successfully.")

# Create relationships between twins
for i in range(1, 10):  # Only create relationships for the first 9 twins
    source_twin = f"myTwin{i}"
    target_twin = f"myTwin{i + 1}"
    relationship_id = f"rel_{i}"

    relationship = {
        "$relationshipId": relationship_id,
        "$sourceId": source_twin,
        "$relationshipName": "connectedTo",  # Name of the relationship
        "$targetId": target_twin
    }
    
    # Create or update the relationship
    client.upsert_relationship(source_twin, relationship_id, relationship)
    print(f"Relationship {relationship_id} created between {source_twin} and {target_twin}.")

