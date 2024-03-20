Docker Concepts

Docker Volumes : To share data between host and contaniers (Not part of images)
Two main Varieties
Persistent - will stay also after conatiner exits
Ephemeral - will be gone when no conatiner is using them


Docker Registries - place to get and commit images

Dockerfiles:

Used to build images
Contains all instruction(commands) to build a image
Docker build is command used to build image using Dockerfile
Each time you run build it will create a new image. Old image is unchanged
State of previous line is not carried forward do all in one line (like downloading and removing the downloaded file)
https://docs.docker.com/engine/reference/builder/
Each step is cached in docker file (if nothing is changed it will not run)
ENV(enivronment variable) will stay accross image

Multi Stage builds

usefull docker command for debugging
docker inspect