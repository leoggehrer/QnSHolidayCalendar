#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["QnSHolidayCalendar.AspMvc/QnSHolidayCalendar.AspMvc.csproj", "QnSHolidayCalendar.AspMvc/"]
COPY ["QnSHolidayCalendar.Adapters/QnSHolidayCalendar.Adapters.csproj", "QnSHolidayCalendar.Adapters/"]
COPY ["QnSHolidayCalendar.Transfer/QnSHolidayCalendar.Transfer.csproj", "QnSHolidayCalendar.Transfer/"]
COPY ["CommonBase/CommonBase.csproj", "CommonBase/"]
COPY ["QnSHolidayCalendar.Contracts/QnSHolidayCalendar.Contracts.csproj", "QnSHolidayCalendar.Contracts/"]
COPY ["QnSHolidayCalendar.Logic/QnSHolidayCalendar.Logic.csproj", "QnSHolidayCalendar.Logic/"]
RUN dotnet restore "QnSHolidayCalendar.AspMvc/QnSHolidayCalendar.AspMvc.csproj"
COPY . .
WORKDIR "/src/QnSHolidayCalendar.AspMvc"
RUN dotnet build "QnSHolidayCalendar.AspMvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "QnSHolidayCalendar.AspMvc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "QnSHolidayCalendar.AspMvc.dll"]