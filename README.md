# chatter
Rapid testing of signalr with angular client

# How to run

1. Run back end aspnetcore project

From Chatter.Backend/Chatter.Backend folder (the one containing the Chatter.Backend.csproj)

Execute the following command.

```shell
dotnet run
```

The razor web app will be reachable at https://localhost:5001/

2. Run angular webapp

From Chatter.Backend/Chatter.Backend folder (the one containing the Chatter.Backend.csproj)

If the webapp have never been launched you need to get the npm packages, so run the npm install command

```shell
npm i
```

Then, you can execute the angular dev server with

```shell
npm run start
```

The angular web app will be reachable at http://localhost:4200/

3. Write somme text in the https://localhost:5001/ page textbox and hit enter
4. The message should be displayed in the angular web app at http://localhost:4200/