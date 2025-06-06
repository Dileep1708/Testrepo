### User Story Details

| Key      | Summary              | Description                                                                                                    | Acceptance Criteria                                                                                  |
|----------|----------------------|----------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------|
| PM1-940  | Sort Search Results  | As a user, I want to sort search results by price, popularity, or rating.                                      | User can choose a sorting option and see the results reordered accordingly.                          |

---

### Test Cases

| TC ID   | Scenario                        | Steps                                                                                  | Expected Result                                              |
|---------|---------------------------------|----------------------------------------------------------------------------------------|--------------------------------------------------------------|
| TC01    | Sort by Price (Low to High)     | Select "Price: Low to High" from sort options                                          | Results are ordered by ascending price                       |
| TC02    | Sort by Price (High to Low)     | Select "Price: High to Low" from sort options                                          | Results are ordered by descending price                      |
| TC03    | Sort by Popularity              | Select "Popularity" from sort options                                                  | Results are ordered by popularity                            |
| TC04    | Sort by Rating                  | Select "Rating" from sort options                                                      | Results are ordered by rating                                |
| TC05    | No Results                      | Perform search with no results, try sorting                                            | No error, empty results remain                               |
| TC06    | Invalid Sort Option             | Manipulate request to use an invalid sort option                                       | Error message or default sort applied                        |
| TC07    | Sorting Persists on Refresh     | Select a sort option, refresh the page                                                 | Results remain sorted as per selected option                 |
| TC08    | Sorting with Identical Values   | Sort when multiple items have the same price/popularity/rating                         | Items with identical values maintain a consistent order      |
| TC09    | Sorting with Large Dataset      | Sort a large number of results                                                         | Results are sorted correctly, performance is acceptable      |
| TC10    | Sorting with Special Characters | Sort when some items have missing or special characters in price/popularity/rating     | Results are sorted, items with missing values handled safely |

---

### Test Plan

| Phase         | Activity                                  | Description                                                                 |
|---------------|-------------------------------------------|-----------------------------------------------------------------------------|
| Preparation   | Test environment setup                    | Prepare search data with various prices, popularity, and ratings             |
| Execution     | Functional testing                        | Execute all positive and negative test cases                                |
| Validation    | UI and UX validation                      | Ensure sorting options are visible and usable                               |
| Regression    | Regression testing                        | Verify sorting after other search-related changes                           |
| Performance   | Performance testing                       | Test sorting with large datasets                                            |
| Reporting     | Defect logging and reporting              | Log any issues found and report test results                                |

---

### Test Data

| Item ID | Price | Popularity | Rating | Notes                        |
|---------|-------|------------|--------|------------------------------|
| 1       | 10    | 100        | 4.5    | Normal item                  |
| 2       | 20    | 200        | 4.7    | Higher price, higher rating  |
| 3       | 10    | 150        | 4.0    | Same price, different pop.   |
| 4       | 5     | 50         | 3.5    | Lowest price                 |
| 5       | 30    | 80         | 5.0    | Highest price, highest rating|
| 6       |       | 120        | 4.2    | Missing price                |
| 7       | 15    |            | 4.3    | Missing popularity           |
| 8       | 25    | 180        |        | Missing rating               |
| 9       | 10    | 100        | 4.5    | Duplicate values             |
| 10      | 12    | 90         | 4.1    | Special characters in name   |### User Story Details

| Key      | Summary                      | Description                                                                                                                      | Acceptance Criteria                                                                                      |
|----------|------------------------------|----------------------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------|
| PM1-939  | Filter Products by Category  | As a user, I want to filter search results by product category to narrow down my search.                                          | User can select one or more categories and see only products from those categories in the results.        |

---

### Test Cases

| Test Case ID | Scenario                                      | Steps                                                                                  | Expected Result                                                                                  |
|--------------|-----------------------------------------------|----------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------|
| TC1          | Filter by single category                     | 1. Open search results<br>2. Select one category<br>3. Apply filter                    | Only products from the selected category are displayed                                           |
| TC2          | Filter by multiple categories                 | 1. Open search results<br>2. Select multiple categories<br>3. Apply filter              | Only products from the selected categories are displayed                                         |
| TC3          | No category selected                          | 1. Open search results<br>2. Do not select any category<br>3. Apply filter              | All products are displayed (no filtering applied)                                                |
| TC4          | Category with no products                     | 1. Open search results<br>2. Select a category with no products<br>3. Apply filter      | No products are displayed; appropriate message shown                                             |
| TC5          | Deselect all categories after filtering       | 1. Select categories<br>2. Apply filter<br>3. Deselect all categories<br>4. Apply filter| All products are displayed                                                                      |
| TC6          | Invalid category selection (negative)         | 1. Manipulate request to select a non-existent category                                 | Error message or no products displayed; system does not crash                                    |
| TC7          | Rapidly change category selections            | 1. Quickly select/deselect categories and apply filter repeatedly                       | System remains stable; results update correctly                                                  |

---

### Test Plan

| Phase         | Activity                                      | Description                                                                                 |
|---------------|-----------------------------------------------|---------------------------------------------------------------------------------------------|
| Preparation   | Test environment setup                        | Prepare product data with multiple categories, including empty categories                   |
| Execution     | Functional testing                            | Execute all positive and negative test cases                                                |
| Execution     | UI testing                                    | Verify category selection UI and filter application                                         |
| Execution     | Edge case testing                             | Test with no products, all products, and invalid categories                                |
| Reporting     | Result documentation                          | Log results, defects, and screenshots if necessary                                         |

---

### Test Data

| Product ID | Product Name   | Category      |
|------------|---------------|---------------|
| 1          | Laptop        | Electronics   |
| 2          | T-shirt       | Clothing      |
| 3          | Headphones    | Electronics   |
| 4          | Coffee Mug    | Home & Kitchen|
| 5          | Sneakers      | Footwear      |
| 6          | Book          | Books         |
| 7          | Blender       | Home & Kitchen|
| 8          | Jacket        | Clothing      |
| 9          | (none)        | EmptyCategory |

**Categories:** Electronics, Clothing, Home & Kitchen, Footwear, Books, EmptyCategory

**Note:** Adjust product and category names as per your application data.### User Story Details

| Key      | Summary                | Description                                                                                                              | Acceptance Criteria                                                                                   |
|----------|------------------------|--------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------|
| PM1-938  | Keyword-Based Search   | As a user, I want to search for products using keywords so that I can quickly find relevant items.                       | User can enter keywords in the search bar and receive a list of matching products.                   |

---

### Test Cases

| Test Case ID | Scenario                        | Steps                                                                 | Expected Result                                      |
|--------------|---------------------------------|-----------------------------------------------------------------------|------------------------------------------------------|
| TC01         | Search with valid keyword        | 1. Enter "laptop" in search bar<br>2. Click search                    | List of products matching "laptop" is displayed      |
| TC02         | Search with partial keyword      | 1. Enter "lap" in search bar<br>2. Click search                       | List of products containing "lap" is displayed       |
| TC03         | Search with no matching keyword  | 1. Enter "xyz123" in search bar<br>2. Click search                    | "No products found" message is displayed             |
| TC04         | Search with empty input          | 1. Leave search bar empty<br>2. Click search                           | Prompt to enter a keyword or no action taken         |
| TC05         | Search with special characters   | 1. Enter "@#$%" in search bar<br>2. Click search                       | "No products found" or error message is displayed    |
| TC06         | Search with case variation       | 1. Enter "LAPTOP" in search bar<br>2. Click search                     | List of products matching "laptop" is displayed      |
| TC07         | Search with leading/trailing spaces | 1. Enter "  laptop  " in search bar<br>2. Click search                | List of products matching "laptop" is displayed      |

---

### Test Plan

| Phase         | Activity                          | Description                                                      |
|---------------|-----------------------------------|------------------------------------------------------------------|
| Preparation   | Test environment setup            | Prepare test data and environment                                |
| Execution     | Functional testing                | Execute positive and negative test cases                         |
| Validation    | Results verification              | Verify search results and error messages                         |
| Reporting     | Defect logging                    | Log any issues found during testing                              |
| Regression    | Re-testing after fixes            | Re-run failed test cases after bug fixes                         |

---

### Test Data

| Test Data ID | Input Keyword      | Expected Result                        |
|--------------|-------------------|----------------------------------------|
| TD01         | laptop            | Products related to "laptop"           |
| TD02         | lap               | Products containing "lap"              |
| TD03         | xyz123            | No products found                      |
| TD04         | (empty)           | Prompt to enter a keyword              |
| TD05         | @#$%              | No products found or error message     |
| TD06         | LAPTOP            | Products related to "laptop"           |
| TD07         |   laptop   (spaces) | Products related to "laptop"           |