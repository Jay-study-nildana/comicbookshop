# how to run

find info about running the project locally.

Video Guides

1. [https://youtu.be/ULdF8ehnjR0](https://youtu.be/ULdF8ehnjR0) : Video that shows how to download, configure and run the project locally.
1. [https://youtu.be/OPjs9nOiKjY](https://youtu.be/OPjs9nOiKjY) : Video walkthrough of the project, like a live demo. 

There are a total of 8 projects. 7 micro services. 1 class library. You need to get the following keys/secrets before building this.

1. The project is built using a locally running SQL server. So, update the 'DefaultConnection' accordingly as per the name or your local server or azure server. Automatic db update is enabled in all projects, but you could do 'update-database' individually to make sure your db is ready.
1. Update the 'ServiceBusConnectionString' with the azure service bus shared access key.
1. Update the 'connectionString' in MessageBus also with the azure service bus shared access key.
1. Create the queues as per the appsettings.json of each project in your azure service. 
1. Create a 256 bit key, and put it as 'Secret' (for OAuth/Identity)
1. Create a Stripe key, and put it in 'SecretKey' (for Stripe Payment Processing). Remember to use the 'test' key and not the publishable key.
1. Except for the 'MessageBus' project (which is class library), every other project should be running at the same time via Multiple startup project option.

# book a session with me

1. [calendly](https://calendly.com/jaycodingtutor/30min)

# hire and get to know me

find ways to hire me, follow me and stay in touch with me.

1. [github](https://github.com/Jay-study-nildana)
1. [personal site](https://thechalakas.com)
1. [upwork](https://www.upwork.com/fl/vijayasimhabr)
1. [fiverr](https://www.fiverr.com/jay_codeguy)
1. [codementor](https://www.codementor.io/@vijayasimhabr)
1. [stackoverflow](https://stackoverflow.com/users/5338888/jay)
1. [Jay's Coding Channel](https://www.youtube.com/channel/UCJJVulg4J7POMdX0veuacXw/)
1. [medium blog](https://medium.com/@vijayasimhabr)