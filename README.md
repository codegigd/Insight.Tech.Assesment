# Insight.Tech.Assesment
Tech Assesment


--> Utilising a modern Infrastructure as Code approach, develop a CI/CD pipeline that can
repeatably and reliably deploy a platform that can host apps, databases and securely
store secrets

For the CI/CD part , I have created ARM to craete Web App and SQL but for the deployment I have added sample file.

--> Implement a mechanism that sends notifications to an internal product review team when
a new product is added

I have prefered to use Logci App , with SQL and Gmail connector, by assuming API connection will be available already

--> Implement the Get Products API endpoint from the Consumer Data Standards Banking
APIs (e.g. https://consumerdatastandardsaustralia.github.io/standards/#get-products) to
be hosted on the new platform

I have added SQL script to craete and insert data into table, you can execute it into DB. Also I have used here .net core secret manager (secret.json) to store the connection string information instead of storing it into applicatiosettings.json file.
