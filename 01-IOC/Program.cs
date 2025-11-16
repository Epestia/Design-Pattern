using _01_IOC.Service.IService;

var container = new Container();
container.Register<IService, ServiceA>();

var service = container.Resolve<IService>();
service.Execute();
