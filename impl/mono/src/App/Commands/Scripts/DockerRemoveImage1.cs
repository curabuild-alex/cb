





docker stop `docker ps -q`

docker rm `docker ps -aq --no-trunc --filter "status=exited"`

docker rmi `docker images --filter 'dangling=true' -q --no-trunc`

docker rm 