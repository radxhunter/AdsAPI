# AdsAPI

Example API with in-memory mock data.

API contains method to:

- return data about TwinCAT variables to communicate via Ads protocol 
- add your custom Ads device using AddDevice(DeviceAddDto deviceAddDto) method.

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

You can push container to docker hub:

`docker push <docker user id>/deviceservice`



Now Try the API (e.g. by Postman) on example endpoint http://localhost:8080/api/device



