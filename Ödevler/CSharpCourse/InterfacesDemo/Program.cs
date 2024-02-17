using InterfacesDemo;

IWorker[] workers = new IWorker[3]
{
    new Worker(),
    new Manager(),
    new Robot()
};

foreach (var worker in workers)
{
    worker.Work();
}