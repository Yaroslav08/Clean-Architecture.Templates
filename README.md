# Clean-Architecture Templates

**This is a template for create project on Clean Architecture design by provide of MVC and WebApi**

## First step (install)
We must download one archives from this [folder](https://github.com/Yaroslav08/Clean-Architecture.Templates) and copy to C:\Users\{current_user}\Documents\Visual Studio 2019\Templates\ProjectTemplates 

## Second step (create project)
Select a one of template and click "Next@"
![image](https://user-images.githubusercontent.com/38474523/101913821-2e3c4100-3bcc-11eb-8442-9c9c4fabccd4.png)

Enter a name your project and click "Create"
![image](https://user-images.githubusercontent.com/38474523/101914026-722f4600-3bcc-11eb-9105-47c018503d4f.png)

After this we get a ready project with small functionality, and they have next structure:
![image](https://user-images.githubusercontent.com/38474523/101914452-039eb800-3bcd-11eb-8961-823aa734fdbe.png)

## Third step (configuring the database)
Since our template has a connection to the sql server, we need to configure it.  
First of all you can rename Context and/or changed connection string
![image](https://user-images.githubusercontent.com/38474523/101915117-dacaf280-3bcd-11eb-9d7f-c50029969e25.png)
After configuration Context we must create migration in PMC (select Shop.Infrastructure.Data project)
![image](https://user-images.githubusercontent.com/38474523/101915652-92f89b00-3bce-11eb-85b1-9e6bb609f857.png)

# Last step
All done, the project configuration is complete, let's try to run it!  
Great, it works!  
![image](https://user-images.githubusercontent.com/38474523/101916195-48c3e980-3bcf-11eb-8343-87b3a70334df.png)
