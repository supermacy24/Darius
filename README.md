# Darius

Darius (Digital Assistant Real-time Interaction Utilities and Services) is an AI-powered personal assistant

## Status 

Early development

## Project Structure

- `src/` - application source code
  - `Darius.Api/` - ASP.NET Core minimal API
    - `Features/` - feature folders (endpoint, models, and service per feature)
    - `Configuration/` - strongly-typed options bound from `appsettings.json`
- `firmware/` - ESP-IDF embedded firmware
- `docs/` - project documentation

## Features

- **Clock** (`GET /clock`) - returns the current UTC time
- **Weather** (`GET /weather`) - returns current weather conditions from [Open-Meteo](https://open-meteo.com/) for the location configured in `appsettings.json` (`Weather:LocationName`, `Weather:Latitude`, `Weather:Longitude`)

## Running

```bash
dotnet run --project src/Darius.Api