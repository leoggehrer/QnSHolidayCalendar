#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["QnSHolidayCalendar.WebApi/QnSHolidayCalendar.WebApi.csproj", "QnSHolidayCalendar.WebApi/"]
COPY ["QnSHolidayCalendar.Transfer/QnSHolidayCalendar.Transfer.csproj", "QnSHolidayCalendar.Transfer/"]
COPY ["CommonBase/CommonBase.csproj", "CommonBase/"]
COPY ["QnSHolidayCalendar.Contracts/QnSHolidayCalendar.Contracts.csproj", "QnSHolidayCalendar.Contracts/"]
COPY ["QnSHolidayCalendar.Logic/QnSHolidayCalendar.Logic.csproj", "QnSHolidayCalendar.Logic/"]
RUN dotnet restore "QnSHolidayCalendar.WebApi/QnSHolidayCalendar.WebApi.csproj"
COPY . .
WORKDIR "/src/QnSHolidayCalendar.WebApi"
RUN dotnet build "QnSHolidayCalendar.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "QnSHolidayCalendar.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "QnSHolidayCalendar.WebApi.dll"]