# Start with a base image that contains the .NET SDK for building
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

# Set the working directory inside the container
WORKDIR /app

# Copy the Web API project files to the container
COPY *.csproj ./
RUN dotnet restore

# Copy the entire Web API project contents to the container
COPY . ./

# Build the Web API project inside the container
RUN dotnet publish -c Release -o out

# Create the final runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0

# Set the working directory inside the container
WORKDIR /app

# Copy the published output from the build-env to the container
COPY --from=build-env /app/out ./

# Expose the port on which the Web API will listen (change 80 to your desired port)
EXPOSE 80

# Start the Web API when the container starts
ENTRYPOINT ["dotnet", "mpdc-backend-services.dll"]
