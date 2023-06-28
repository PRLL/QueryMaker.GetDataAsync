## What is QueryMaker.GetDataAsync?

QueryMaker.GetDataAsync is an extension package for [QueryMaker](https://github.com/PRLL/QueryMaker) which adds the functionality to get the resulting data asynchronously.

<br />



## Installation

First, as this is an extension you will need to have [QueryMaker](https://github.com/PRLL/QueryMaker) already installed. Then, install [QueryMaker.GetDataAsync](https://www.nuget.org/packages/QueryMaker.GetDataAsync/) from the package manager console:

  ```
  PM> Install-Package QueryMaker.GetDataAsync
  ```

  Or from the .NET CLI as:

  ```powershell
  dotnet add package QueryMaker.GetDataAsync
  ```

<br />



## How To Use

With the package already installed on your project, now you can call the `GetDataAsync()` extension method from a `QueryMakerResult` instance:

  ```csharp
  using QueryMakerLibrary;
  using QueryMakerLibrary.GetDataAsync;

  ...

  // first, we make the queries using QueryMaker...
  QueryMakerResult<T> result = _dbContext.TableEntity.MakeQueryResult(queryMaker);

  // ... then, we can use the GetDataAsync() extension method to get the data asynchronously
  QueryMakerData<T> data = await result.GetDataAsync();
  ```

The resulting `QueryMakerData` object contains two properties:

  * __T[] Items__ - array containing the resulting items.
  * __int TotalAmmount__ - count of the total ammount of items withouth pagination.

<br />


## License

Distributed under the GNU General Public License v3.0 License. See `LICENSE.md` for more information.

<br />



## Contact

LinkedIn: [Jose Toyos](https://www.linkedin.com/in/josetoyosvargas/)

Email: josemoises.toyosvargas@hotmail.com

Project Link: [https://github.com/PRLL/QueryMaker.GetDataAsync](https://github.com/PRLL/QueryMaker.GetDataAsync)

<br />



## Copyright

©Jose Toyos 2023
