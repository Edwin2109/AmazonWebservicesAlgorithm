::This bat-file runs an MSbuild tool to build the solution without a need for the VS environment
c:\Windows\Microsoft.NET\Framework64\v4.0.30319\msbuild.exe AmazonWebservicesAlgorithm.sln /t:Clean,Build
::Change directory to where the test dll resides
cd AmazonWebservicesAlgorithm.Test\bin\Debug\
::Run a bat-file that execute the tests
call unit-tests.bat
pause