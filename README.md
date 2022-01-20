# ASP.net MVC
social network with chat
## Code Overview

- `ChatApplication.Entities` is Entity Layer of project
    * `ChatApplication.Entities/Domain` is database folder of project.
    * `ChatApplication.Entities/Trackable` is base entity folder.
- `ChatApplication.Shared` is Shared project.
- `ChatApplication.Core` is Data access Layer of project.
    * `ChatApplication.Core/Abstract` is Repositories folder. This folder contains UnitOfWork pattern.
    * `ChatApplication.Core/Concrete` contains repositories implements , database context , and mapping.
- `ChatApplication.WebUI` is UI folder of project.
    - `ChatApplication.WebUI/Controllers` contains controllers.
    - `ChatApplication.WebUI/Hubs` contains SingalR Hub Class.
    - `ChatApplication.WebUI/ViewComponents` contains view components.
    - `ChatApplication.WebUI/Views` contains views and layouts.
