This repo is created to gather the knowledge from YT course .NET Microservices – Full Course, you can find it in link https://www.youtube.com/watch?v=DgVjEo3OGBI&t=9743s

# AdsAPI

Example API with in-memory mock data.

API contains method to:

- return data about TwinCAT variables to communicate via Ads protocol 
- add your custom Ads device using `AddDevice(DeviceAddDto deviceAddDto)` method.

API has the following layers (except DB - right now it contains in-memory data):

![image-20210907075025138](C:\Users\rsendecki\AppData\Roaming\Typora\typora-user-images\image-20210907075025138.png)





# **Containerize the app**

Download the docker desktop, Enable Kubernetes checkbox and create an account on https://hub.docker.com/
My docker version is 20.10.8, build 3967b7d.

Type in terminal in project root folder:

`docker build -t <docker user id>/deviceservice .`

`docker run -p 8080:80 -d <docker user id>/deviceservice `

Check is container running:

`docker ps`

You can stop and start the container:

`docker stop <container id>`

`docker start <container id>`

Now push your container to docker hub:

`docker push <docker user id>/deviceservice`



Now Try the API (e.g. by Postman) on example endpoint http://localhost:8080/api/device



# Use Kubernetes

![image-20210908102635499](C:\Users\rsendecki\AppData\Roaming\Typora\typora-user-images\image-20210908102635499.png)

In *K8S/adsdevices-depl.yaml* change the last line with following content:

`image: radxhunter/adsdevicesservice:latest`

Type your docker user id:

`image: <docker user id>/adsdevicesservice:latest`



Check is kubernetes working:

`kubectl version`

Change directory to:

`cd .\K8S`

Apply deployment:

`kubectl apply -f adsdevices-depl.yaml`

You can see your pods and deployments:

`kubectl get deployments`

`kubectl get pods`

If you want delete deployment type this:

`kubectl detele deployment adsdevices-depl`



Now you can apply your Node Port service:

`kubectl apply -f adsdevices-np-srv.yaml`

You can see your services:

`kubectl get services`



Now Try the API (e.g. by Postman) on example endpoint http://localhost:`<your app IP port>`/api/device
You will find your IP Port with `kubectl get services` command:

![image-20210908103136407](C:\Users\rsendecki\AppData\Roaming\Typora\typora-user-images\image-20210908103136407.png)

