### Test Automation Project

[![.NET](https://github.com/shreyansh268/testapp/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/shreyansh268/testapp/actions/workflows/build.yml)

#### Description
Test automation framework developed to create tests for validating UI and API layers
of a popular weather web application.
https://openweathermap.org/

#### Tech Stack
- Test Framework - [NUnit 3](https://nunit.org/)
- UI Automation - [Selenium 4](https://www.selenium.dev/)
- API Automation - [OpenWeatherMap-API Library](https://github.com/swiftyspiffy/OpenWeatherMap-API-CSharp)
- Development Platform - [.Net 6](https://docs.microsoft.com/en-us/dotnet/core/introduction)

#### Execution
Requirements:   
1. .Net6
2. Git

Steps:   
1. Clone the git repository using cmd terminal and git clone command
      - create a folder "XYZ"
      - open terminal and command "git clone https://github.com/shreyansh268/testapp"
      - repository is downloaded in local file system

2. Run tests
      - navigate to repository root folder "cd testapp"
      - run tests using "dotnet test"
      - test should start

3. Results
      - html report file is generated @"\testapp\bin\Debug\net6.0\Report"

#### Issues Identified
1. Test task failing on Github Actions workflow - Chrome crashing

#### Enhancements Identified
1. Implement Selenium grid with Docker
2. Enhace report logging
3. Implement Workflow layer in framework between Page Object Model and Test classes
4. Implement support for web browsers
