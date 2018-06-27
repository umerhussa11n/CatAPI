# CatAPI
Cat API wihch shows list of Categories and Filters Images based on Category, .NetCore, Xunit, Unit test & Integration test.

Questions;
1. How long did you spend on the coding test?
I spent about 4 hours. 

2. What would you change / implement in your application given more time?
I would add a new web MVC project / create controller & view and call these API's so that there is a front end available for the users.
I would also improve the error handling and add log error and warnings in the application in more places.
I would also add more unit and integration tests to handle various different scenarios.
I would also connect the application to the data base so real time data can be displayed to users inseted of using fake data/ In memory objects.

3. Did you use IOC? Please explain your reasons either way.
this is handled very elegantly in .net Core.
I injected the services in the API controller's and data providers are injectd into the services hence each cass is trying to just perform 
according to its own responsibility and gives the responsibility to the dependencies where appropriate.
Asp.net core has some features to inject some basic services like logservice which I did in the CategoriesAPI Controller.

4. How would you debug an issue in production code?
i will look into the error logs for warnings or errors depending upon the issue,
replicating the issue on the test envirnoment so that I can create/change data if required 
& if it is replicated on the test envirnoemnt then I will look into the code to get this fixed.
add a unit test if possible so that this shouldn't happen again.

5. What improvements would you make to the cat API?
I would seperate the unit tests in the test appliaction. Unit tests are quicker and provide a quick update on the results. 
Units tests makes use of mocks or fakes so that most of the frameowrk dependencies are excluded. Integration tests however will be slower
as they need some of the framework features as well so this is ideal to seperate these two.

6. What are you two favourite frameworks for .Net?
Asp.Net MVC and Asp.Net WebAPI.

7. What is your favourite new feature in .Net?
Asp.Net Core is my favourite new feature in .net for it being open source and highly modular. the is builtin support for Dependency Injection
however DI container like unity can still be used. hosting .net applications on OSX and Linus are possible using .net core.

8. Describe yourself in JSON.

{
"first name": "umer",
"profession": ".net developer",
"hobbies": "travel, sports",
"education": "Bsc Hons",
"degree": "computer science",
}
