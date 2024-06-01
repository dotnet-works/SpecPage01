## Living Doc [Generate Report]

Step 1: 
$ Admin@DESKTOP-SRRVDGO E:\DotnetWorks\SpecPage01\bin\Debug\net8.0
$ dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI

Step 2:
$ Admin@DESKTOP-SRRVDGO E:\DotnetWorks\SpecPage01\bin\Debug\net8.0
$ livingdoc test-assembly SpecPage01.dll -t TestExecution.json
