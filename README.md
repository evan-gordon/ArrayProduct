## Product of Two Arrays

Given an array nums of n integers where n > 1,  return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].

Note: Solve it without division and in O(n).

## Example
```
Input:  [1,2,3,4]
Output: [24,12,8,6]
```

## To Run
```
# from root dir
dotnet run --project src/

# from src/ dir
dotnet run
```

## To Test
```
# root dir
dotner run test/

# from test/ dir
dotnet test
```

### Contribution
If you see any issues with the current setup, or want to make the project more general feel free to submit a PR.

### Steps Used in Project ceation
```
#init dotnet console app
cd src/
dotnet new console

#init test
cd ../test/
dotnet new xunit
dotnet add reference ../src/src.csproj
```