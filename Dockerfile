FROM mcr.microsoft.com/dotnet/core/sdk:2.2
WORKDIR /home/zippyops/myWebApp
COPY . /home/zippyops/myWebApp
RUN dotnet restore
RUN apt-get update && apt-get install -y ntp
RUN service ntp start
RUN export DOTNET_CLI_HOME="/tmp/DOTNET_CLI_HOME"
EXPOSE 5000
#EXPOSE 5001
CMD [ "dotnet", "run" ]



#ENTRYPOINT [ "dotnet", "watch", "run", "--no-restore", "--urls", "https://0.0.0.0:5000"]

