### User Story Details

| Key      | Summary               | Description                                                                                                   | Acceptance Criteria                                               |
|----------|-----------------------|--------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------|
| PM1-984  | Sort Search Results   | As a user, I want to sort search results by price or relevance to view products in my preferred order.        | User can select sorting options and see results reordered.        |

---

### Test Cases

| Test Case ID | Scenario                                      | Steps                                                                                  | Expected Result                                 |
|--------------|-----------------------------------------------|----------------------------------------------------------------------------------------|-------------------------------------------------|
| TC1          | Sort by Price (Low to High)                   | 1. Search for products<br>2. Select "Price: Low to High"                               | Results sorted by ascending price               |
| TC2          | Sort by Price (High to Low)                   | 1. Search for products<br>2. Select "Price: High to Low"                               | Results sorted by descending price              |
| TC3          | Sort by Relevance                             | 1. Search for products<br>2. Select "Relevance"                                        | Results sorted by relevance                     |
| TC4          | No Sorting Option Selected                    | 1. Search for products<br>2. Do not select any sorting option                          | Default sorting applied                         |
| TC5          | Invalid Sorting Option                        | 1. Search for products<br>2. Select an invalid sorting option (simulate error)         | Error message or fallback to default sorting    |
| TC6          | Sorting with No Results                       | 1. Search for a term with no results<br>2. Select any sorting option                   | No results displayed, no errors                 |
| TC7          | Sorting with Identical Prices                 | 1. Search for products with same price<br>2. Sort by price                             | Results maintain original or relevance order    |
| TC8          | Sorting with Large Result Set                 | 1. Search for a term with many results<br>2. Sort by price or relevance                | Results sorted correctly, performance acceptable|

---

### Test Plan

| Phase         | Activity                                   | Description                                                                 |
|---------------|--------------------------------------------|-----------------------------------------------------------------------------|
| Preparation   | Test environment setup                     | Prepare test data and configure environment                                 |
| Execution     | Functional testing                         | Execute all positive and negative test cases                                |
| Validation    | UI and UX validation                       | Ensure sorting options are visible and usable                               |
| Performance   | Sorting performance                        | Test sorting with large datasets                                            |
| Reporting     | Defect logging and reporting               | Log any issues found and report test results                                |

---

### Test Data

| Product Name   | Price | Relevance Score | Notes                        |
|----------------|-------|-----------------|------------------------------|
| Product A      | $10   | 90              |                              |
| Product B      | $20   | 80              |                              |
| Product C      | $10   | 85              | Same price as Product A      |
| Product D      | $30   | 70              |                              |
| Product E      | $15   | 95              | Highest relevance            |
| Product F      | $25   | 60              |                              |
| (No Results)   | -     | -               | For empty search scenario    |### User Story Details

| Key      | Summary                | Description                                                                                                         | Acceptance Criteria                                                                                   |
|----------|------------------------|---------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------|
| PM1-983  | Filter Search Results  | As a user, I want to filter search results by category and price range to narrow down my options.                   | User can apply category and price filters, and results update accordingly.                            |

---

### Test Cases

| Test Case ID | Scenario                                      | Steps                                                                                   | Expected Result                                      |
|--------------|-----------------------------------------------|-----------------------------------------------------------------------------------------|------------------------------------------------------|
| TC1          | Apply valid category filter                   | Select a category filter and apply                                                      | Results show only items from selected category        |
| TC2          | Apply valid price range filter                | Enter a valid price range and apply                                                     | Results show only items within price range            |
| TC3          | Apply both category and price range filters   | Select category, enter price range, and apply                                           | Results match both filters                            |
| TC4          | Apply filter with no matching results         | Select category/price range with no matching items                                      | Results show "No results found" message               |
| TC5          | Apply invalid price range (min > max)         | Enter min price greater than max price and apply                                        | Error message shown, results not updated              |
| TC6          | Clear filters                                 | Apply filters, then clear them                                                          | All results are shown                                 |
| TC7          | Apply empty filters                           | Do not select any filters and apply                                                     | All results are shown                                 |
| TC8          | Apply non-numeric price input                 | Enter non-numeric values in price fields and apply                                      | Error message shown, results not updated              |

---

### Test Plan

| Phase         | Activity                                 | Description                                                                 |
|---------------|------------------------------------------|-----------------------------------------------------------------------------|
| Preparation   | Test environment setup                   | Prepare test data and environment                                           |
| Execution     | Functional testing                       | Execute all positive and negative test cases                                |
| Validation    | Results verification                     | Verify results update as per filters and error handling                     |
| Regression    | Regression testing                       | Ensure existing search functionality is not broken                          |
| Reporting     | Defect logging and reporting             | Log any issues found and report test results                                |

---

### Test Data

| Category      | Min Price | Max Price | Expected Result           |
|---------------|-----------|-----------|--------------------------|
| Electronics   | 100       | 500       | Filtered electronics     |
| Books         | 10        | 50        | Filtered books           |
| Clothing      | 20        | 100       | Filtered clothing        |
| Electronics   | 1000      | 2000      | No results               |
| Books         | 50        | 10        | Error (min > max)        |
| Clothing      | abc       | 100       | Error (non-numeric)      |
| (none)        | (none)    | (none)    | All results              |### User Story Details

| Key      | Summary               | Description                                                                                                   | Acceptance Criteria                                                        |
|----------|----------------------|--------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------|
| PM1-982  | Basic Product Search  | As a user, I want to search for products by name so that I can quickly find what I am looking for.           | User can enter a product name and see a list of matching products.         |

---

### Test Cases

| Test Case ID | Scenario                        | Steps                                                                 | Expected Result                                      |
|--------------|---------------------------------|-----------------------------------------------------------------------|------------------------------------------------------|
| TC1          | Search with exact product name   | Enter full product name and search                                    | Matching product(s) are displayed                    |
| TC2          | Search with partial name         | Enter part of a product name and search                               | All products containing the partial name are listed   |
| TC3          | Search with no matches           | Enter a name that does not exist and search                           | "No products found" message is displayed             |
| TC4          | Search with empty input          | Leave search box empty and search                                     | All products or a prompt to enter a search term      |
| TC5          | Search with special characters   | Enter special characters and search                                   | No products found or appropriate error message        |
| TC6          | Case insensitivity              | Enter product name in different case (e.g., lowercase/uppercase)      | Matching products are displayed regardless of case   |
| TC7          | Leading/trailing spaces          | Enter product name with spaces before/after and search                | Matching products are displayed                      |

---

### Test Plan

| Phase         | Activity                                  | Responsible | Output                        |
|---------------|-------------------------------------------|-------------|-------------------------------|
| Preparation   | Review requirements, set up test data     | QA          | Test cases, test data         |
| Execution     | Run test cases in VS Code                 | QA          | Test results, bug reports     |
| Reporting     | Document results, report issues           | QA          | Test summary, defect log      |

---

### Test Data

| Product Name      | Exists in DB | Notes                        |
|-------------------|--------------|------------------------------|
| Apple iPhone 14   | Yes          | For exact/partial match      |
| Samsung Galaxy S  | Yes          | For partial match            |
| Headphones        | Yes          | For partial match            |
| NonExistentProd   | No           | For no match scenario        |
| !@#$%^&*()        | No           | For special character test   |
| apple iphone 14   | Yes          | For case insensitivity       |
|   Apple iPhone 14 | Yes          | For leading/trailing spaces  |