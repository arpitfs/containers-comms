# containers-comms
This project is a demostration of a docker containers communication within a composed network. In this project there is one web api which is containerized in a docker container which communicates with sql server coantiner. The web api service is build using docker file where as sql server image is used to compose it. Docker compose is used to build is the images and create the network and injects necessory parameters to the respective conatiners.

### To run the appliation

Go to the path where docker-compose file exists

* Run `docker-compose build` - to build the containers
* Run `docker-compose up` - to build run the containers within a network

Open [http://localhost:3000/api/conatiner](http://localhost:3000/api/conatiner) to view it in the browser.

## TODO : Add migration at the start of the container so that the data is always available when the application starts.

![alt text](https://github.com/arpitfs/containers-comms/blob/master/ContainerComms/ContainerComms/Screenshots/docker-compose.png)
