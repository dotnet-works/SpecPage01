## Living Doc [Generate Report]

Step 1: 
$ Admin@DESKTOP-SRRVDGO E:\DotnetWorks\SpecPage01\bin\Debug\net8.0
$ dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI

Step 2:
$ Admin@DESKTOP-SRRVDGO E:\DotnetWorks\SpecPage01\bin\Debug\net8.0
$ livingdoc test-assembly SpecPage01.dll -t TestExecution.json

#### We Can also generate report at specified location-using relative or abs path

Admin@DESKTOP-SRRVDGO E:\DotnetWorks\SpecPage01\bin\Debug\net8.0
$ livingdoc test-assembly SpecPage01.dll -t TestExecution.json --output ../../../report.html

#### Generate Report For Unused Steps In Step-Definations
Admin@DESKTOP-SRRVDGO E:\DotnetWorks\SpecPage01\bin\Debug\net8.0
$ livingdoc test-assembly SpecPage01.dll --binding-assemblies "SpecPage01.dll"