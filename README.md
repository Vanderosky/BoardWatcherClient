# **BoardWatcherClient Documentary**
Refer to [**BoardWatcher**](https://gitlab.com/board-watcher) for the rest of the project.
## About application
This is client web application for spectating live chess game analysed with BoardWatcher.\
    BoarWatcher Client Application was created with Blazor WebAssembly. This framework has following pros and cons:\
    <ol>
    <li>+Code is written almost exclusively in C# instead of JavaScript.\</li>
    <li>+Has support of entire .NET Framework with all its libraries.\</li>
    </ol>
        +Code is written almost exclusively in C# instead of JavaScript.\
        +Has support of entire .NET Framework with all its libraries.\
        -.NET runtime needs to be shipped together with application, which results in heavier initial bundle size (few megabytes) than JavaScript alternatives.\
        -Some things still can be created only in JavaScript, like implementing downloading file for user.

## How to use
When opened via default [**path**](https://vanderosky.github.io/BoardWatcherClient/), game ID needs to be entered (which should be generated by person running game analyses with original Board Watcher application). Then simply click the button.\
After short connecting, board on the left side should be visible together with moves history table on the right side. Under the board there are also buttons which allows user to change current state of the board, moving it in the history of analysed moves.
\User can also enter into the game by including game ID in the link path, like this: https://localhost:5001/chess/CV/cvID ,where last parameter is game ID

## Running source project

BoardWatcherClient requires [Dotnet-sdk](https://dotnet.microsoft.com/download) 5.0+ to run.

Enter into project directory with terminal, and run application

```sh
dotnet watch run
```
It will run on https://localhost:5001. 
To publish app, run
```sh
dotnet publish -c Release
```

## License

MIT
