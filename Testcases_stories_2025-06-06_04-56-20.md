### User Story Details

| Key      | Summary                  | Description                                                                                                   | Acceptance Criteria                                                                                  |
|----------|--------------------------|---------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------|
| PM1-930  | Display Search Results   | As a user, I want to view search results in a clear and organized manner.                                     | Search results display product name, image, and price in a list or grid format.                      |

---

### Test Cases

| Test Case ID | Scenario                        | Steps                                                                 | Expected Result                                                                 |
|--------------|---------------------------------|-----------------------------------------------------------------------|---------------------------------------------------------------------------------|
| TC01         | Positive: Valid search results  | 1. Enter a valid search term<br>2. Submit search                      | Results display product name, image, and price in list/grid format              |
| TC02         | Negative: No results            | 1. Enter a search term with no matches<br>2. Submit search            | "No results found" message displayed                                            |
| TC03         | Negative: Missing product image | 1. Search for a product with no image                                 | Placeholder image displayed                                                     |
| TC04         | Negative: Missing product price | 1. Search for a product with no price                                 | "Price not available" or similar message shown                                  |
| TC05         | Positive: Grid format           | 1. Switch to grid view<br>2. Search for products                      | Results displayed in grid format with name, image, and price                    |
| TC06         | Positive: List format           | 1. Switch to list view<br>2. Search for products                      | Results displayed in list format with name, image, and price                    |
| TC07         | Negative: Special characters    | 1. Enter special characters as search term<br>2. Submit search        | No crash; appropriate message or empty results                                  |

---

### Test Plan

| Phase         | Activity                                  | Responsible | Output                          |
|---------------|-------------------------------------------|-------------|----------------------------------|
| Preparation   | Review requirements & design test cases   | QA          | Test cases, test data            |
| Execution     | Run test cases in VS Code                 | QA          | Test results, bug reports        |
| Reporting     | Document results & issues                 | QA          | Test summary, defect log         |
| Regression    | Re-test after fixes                       | QA          | Updated test results             |

---

### Test Data

| Search Term     | Product Name      | Image URL           | Price   | Expected Result                         |
|-----------------|------------------|---------------------|---------|-----------------------------------------|
| "laptop"        | UltraBook 2024   | /img/ultrabook.jpg  | $999    | Displayed with image and price          |
| "phone"         | SmartPhone X     | /img/phone.jpg      | $699    | Displayed with image and price          |
| "noimage"       | Old Model Phone  | (empty)             | $199    | Placeholder image shown                 |
| "noprice"       | Mystery Gadget   | /img/gadget.jpg     | (empty) | "Price not available" shown             |
| "xyz123"        | (none)           | (none)              | (none)  | "No results found" message              |
| "!@#$%"         | (none)           | (none)              | (none)  | "No results found" or error handled     |### User Story Details

| Key      | Summary                        | Description                                                                                                   | Acceptance Criteria                                                      |
|----------|-------------------------------|---------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------|
| PM1-929  | Implement Basic Product Search | As a user, I want to search for products by entering keywords so that I can find relevant items quickly.      | User can enter a search term and see a list of matching products.        |

---

### Test Cases

| Test Case ID | Scenario                                 | Steps                                                                 | Expected Result                                      |
|--------------|------------------------------------------|-----------------------------------------------------------------------|------------------------------------------------------|
| TC1          | Search with valid keyword                | Enter "laptop" in search box, click search                            | List of products matching "laptop" is displayed      |
| TC2          | Search with partial keyword              | Enter "lap" in search box, click search                               | List of products containing "lap" is displayed       |
| TC3          | Search with no matching keyword          | Enter "xyz123" in search box, click search                            | "No products found" message is displayed             |
| TC4          | Search with empty input                  | Leave search box empty, click search                                  | All products or prompt to enter a keyword            |
| TC5          | Search with special characters           | Enter "!@#$%" in search box, click search                             | "No products found" or handle gracefully             |
| TC6          | Search with SQL injection attempt        | Enter "' OR 1=1 --" in search box, click search                       | No error, no data leak, handled securely             |
| TC7          | Search with leading/trailing spaces      | Enter "  phone  " in search box, click search                         | Products matching "phone" are displayed              |
| TC8          | Search with case-insensitive keyword     | Enter "LAPTOP" in search box, click search                            | Products matching "laptop" are displayed             |

---

### Test Plan

| Phase         | Activity                                | Description                                                         |
|---------------|-----------------------------------------|---------------------------------------------------------------------|
| Preparation   | Test environment setup                  | Prepare product data, configure search feature                      |
| Execution     | Functional testing                      | Execute all positive and negative test cases                        |
| Validation    | Result verification                     | Verify search results, error handling, and security                 |
| Reporting     | Defect logging and reporting            | Log any issues, report test results                                 |

---

### Test Data

| Test Data ID | Search Term      | Expected Result                      |
|--------------|------------------|--------------------------------------|
| TD1          | laptop           | List of laptops                      |
| TD2          | lap              | Products with "lap" in name/desc     |
| TD3          | xyz123           | No products found                    |
| TD4          | (empty)          | All products or prompt               |
| TD5          | !@#$%            | No products found                    |
| TD6          | ' OR 1=1 --      | No error, no data leak               |
| TD7          |   phone   (spaces)| Products matching "phone"            |
| TD8          | LAPTOP           | List of laptops                      |