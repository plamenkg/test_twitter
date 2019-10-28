# Test twitter API

# Dependencies for executing:
# .Net Core 2.2 SDK needs to be installed on executing machine

# Example execution in CMD:
# 	1. Navigate to project folder | cd $projectDir 
#	2. Run tests 				  | dotnet test TwitterTests.csproj
# 	(Optional) Export results 	  | Add -l:trx;LogFileName=$fileName to the previous line

# Scenario:	Delete comment of a tweet

# Scenario Description:
#	Given I have initialized my OAuth parameters
#	And I have initialized my tweet client with https://api.twitter.com
#	And I created a tweet with text Very original tweet
#	And I replied to the tweet with comment I love it
#	And I have logged into https://twitter.com with username and password
#	And I have navigated to Very original tweet tweet comments
#	When I delete the comment I love it
#	Then it should not be present on the Home page

#Package references:
#	 <PackageReference Include="Microsoft.NET.Test.Sdk" Version="16.2.0"/>
#    <PackageReference Include="Microsoft.TestPlatform.TestHost" Version="16.2.0"/>
#    <PackageReference Include="NUnit" Version="3.12.0"/>
#    <PackageReference Include="NUnit.Console" Version="3.10.0"/>
#    <PackageReference Include="NUnit.ConsoleRunner" Version="3.10.0"/>
#    <PackageReference Include="NUnit.Runners" Version="3.10.0"/>
#    <PackageReference Include="NUnit3TestAdapter" Version="3.15.1"/>
#    <PackageReference Include="RestSharp.NetCore" Version="105.2.3"/>
#    <PackageReference Include="Selenium.Support" Version="3.141.0"/>
#    <PackageReference Include="Selenium.WebDriver" Version="3.141.0"/>
#    <PackageReference Include="Selenium.WebDriver.ChromeDriver" Version="78.0.3904.7000"/>
#    <PackageReference Include="SpecFlow" Version="3.0.225"/>
#    <PackageReference Include="SpecFlow.Assist.Dynamic" Version="1.4.1"/>
#    <PackageReference Include="SpecFlow.NUnit" Version="3.0.225"/>
#    <PackageReference Include="SpecFlow.NUnit.Runners" Version="3.0.225"/>
#    <PackageReference Include="SpecFlow.Tools.MsBuild.Generation" Version="3.0.225"/>	