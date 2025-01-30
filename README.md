# My Public API

## Project Description
This is a simple API that provides the current datetime in ISO 8601 format (UTC).

## Setup Instructions

1. Clone the repository:
2. Navigate to the project directory:
3. Restore dependencies:
4. Run the API locally:
5. Access the API at:

## API Documentation

### Endpoint: `GET /api/info/datetime`
- **Request**: None
- **Response**:
```json
{
 "current_datetime": "2025-01-30T12:00:00.0000000Z"
}

### 5. **Deployment**
You can deploy your API on any cloud platform like Azure, Railway, or Render. Make sure to deploy it to a publicly accessible URL. You already have a `Dockerfile` for easy deployment, which helps when deploying to platforms like Railway or Render.

### 6. **Testing**
Ensure the API works locally:
- Run `dotnet run` and test the endpoint using Postman or Swagger UI (depending on your setup).
- Use `curl` or Postman to test the endpoint:
I
