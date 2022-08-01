# Unit Tests

**Contents**
- [Code Coverage](#codeCoverage)<br>
- [See Also](#seeAlso)<br>

<a id="codeCoverage">**Code Coverage**</a><br>
There are a couple of ways to get code coverage numbers:
- Run locally in Visual Studio
    - Open all.sln, or the solution that contains the product code you want code coverage numbers on.
    - Choose a menu command under Tests > Analyze Code Coverage. Alternately, you can find the command in the Test Explorer tool window under the Run menu or right-click. To get total code coverage numbers for an area of product code, be sure to run all tests. 
    - View results in the Code Coverage Results tool window.
- Use the [Mindaro-CodeCoverage-Build](https://devdiv.visualstudio.com/DevDiv/_build?definitionId=10159) build definition
    - The build is scheduled to run regularly on master, or you can queue a build to get the latest numbers or analyze coverage in your own remote branch.
    - When the build completes, the Summary tab will show an overall percentage.
    - Download detailed results from the build's Code Coverage tab.
    - Open the .coverage results file in Visual Studio by double-clicking, or use the "Import Results" button in the Code Coverage Results tool window.

<a id="seeAlso">**See Also**</a>
- [Unit Test Best Practices](./BESTPRACTICES.md)
