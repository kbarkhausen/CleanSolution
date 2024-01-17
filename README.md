# Clean Solution
Removes all files created during build from the original source.

## Introduction
This EXE will travel through your source code eliminating the files that are commonly added during a build so that you can restore the source to it's pre-build condition. It will eliminate a lot of excess files not needed until you need to build this solution again.

It will eliminate the following folders:
- /bin 
- /obj
- /packages
- /node_modules
- /dist (commonly used to store compiled UI components)
- /tmp (commonly used to store temp files)
- /Test_Results (stores the C# unit testing results)

## Prerequisites
List any prerequisites required to build and run your project. 

- .NET SDK 6.0 or later

## Building the Executable
Explain how to build the executable from the source code. Break it down into step-by-step instructions. For example:

1. **Clone the Repository:**
   - Clone the project repository to your local machine using:
     ```
     git clone [repository URL]
     ```
   - Navigate to the project directory:
     ```
     cd [project name]
     ```

2. **Build the Project:**
   - Run the following command to build the project:
     ```
     dotnet build
     ```

3. **Publish the Application:**
   - Use the following command to publish the application as a self-contained executable:
     ```
     dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
     ```

4. **Locate the Executable:**
   - Find the executable in the `bin/Release/{netcoreapp_version}/{runtime identifier}/publish/` directory.

## Running the Application
Provide instructions on how to run the application after building it. For example:
- Navigate to the publish directory:
  ```
  cd bin/Release/{netcoreapp_version}/{runtime identifier}/publish/
  ```
- Run the executable:
  ```
  ./CleanSolution.exe
  ```

## Additional Notes
Copy this EXE to a local folder such as C:\tools and then add this folder into your computer's PATH. This will make it easy to use anywhere you need to clean up a C# solution.

## License
Free to use. No warranty is provided. Use AS IS with no guarantee or support provided.
