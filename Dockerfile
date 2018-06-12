FROM mono
COPY ConsoleApplication.sln ./
COPY ConsoleApplication ./ConsoleApplication
RUN mono --version
RUN msbuild DockerMonoWCFTestApp.sln
CMD [ "mono",  "./WCFServiceHost/bin/Debug/WCFServiceHost.exe" ]

