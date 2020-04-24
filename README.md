# ContainerComms
This application dotnet core web api which uses EF core to get data when the endpoint is hit.The case is that both th application will run on a different docker container and communicate with each other.It contains a docker yml file which creates a network for both the api and sql container so that they can communicate
