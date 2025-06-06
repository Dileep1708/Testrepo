### User Story Details

| Key      | Summary             | Description                                                                                                                      | Acceptance Criteria                                                                                  |
|----------|---------------------|----------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------|
| PM1-936  | Handle No Results   | As a user, I want to be informed when no products match my search criteria.                                                      | If no products are found, the system displays a message: "No products found matching your criteria."  |

---

### Test Cases

| Test Case ID | Scenario                        | Steps                                                                 | Expected Result                                               |
|--------------|---------------------------------|-----------------------------------------------------------------------|---------------------------------------------------------------|
| TC1          | No products found (positive)    | 1. Enter search criteria with no matching products.<br>2. Submit.     | "No products found matching your criteria." message displayed.|
| TC2          | Products found (negative)       | 1. Enter search criteria with matching products.<br>2. Submit.        | List of matching products displayed; no "no results" message. |
| TC3          | Empty search (negative)         | 1. Leave search field empty.<br>2. Submit.                            | All products displayed; no "no results" message.              |
| TC4          | Special characters (negative)   | 1. Enter special characters as search criteria.<br>2. Submit.         | "No products found matching your criteria." message displayed.|
| TC5          | Case sensitivity (negative)     | 1. Enter search criteria in different case.<br>2. Submit.             | Matching products displayed if exist; else, "no results" message.|

---

### Test Plan

| Phase         | Activity                                      | Expected Outcome                                  |
|---------------|-----------------------------------------------|---------------------------------------------------|
| Preparation   | Set up test environment and test data         | Test environment ready                            |
| Execution     | Run test cases TC1–TC5                        | Results as per expected outcomes                  |
| Reporting     | Log defects and report results                | All issues documented and reported                |
| Regression    | Re-test after fixes                           | All test cases pass                               |

---

### Test Data

| Test Data ID | Search Criteria      | Expected Products | Notes                       |
|--------------|---------------------|-------------------|-----------------------------|
| TD1          | "xyz123"            | None              | No matching products        |
| TD2          | "laptop"            | 3                 | 3 matching products exist   |
| TD3          | "" (empty)          | All               | Returns all products        |
| TD4          | "@#$%"              | None              | No products with special characters |
| TD5          | "LAPTOP"            | 3                 | Case-insensitive search     |### User Story Table

| Key      | Summary                  | Description                                                                                                         | Acceptance Criteria                                                                                 |
|----------|--------------------------|---------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------|
| PM1-935  | Display Product Details  | As a user, I want to see key product details (name, price, image, rating) in the search results.                   | Each product in the search results shows its name, price, image, and rating.                        |

---

### Test Cases Table

| Test Case ID | Scenario                        | Steps                                                                 | Expected Result                                              |
|--------------|---------------------------------|-----------------------------------------------------------------------|--------------------------------------------------------------|
| TC1          | All details displayed           | Search for a product                                                  | Name, price, image, and rating are shown for each product    |
| TC2          | Missing product name            | Search for a product with missing name                                | Placeholder or error shown for missing name                  |
| TC3          | Missing product price           | Search for a product with missing price                               | Placeholder or error shown for missing price                 |
| TC4          | Missing product image           | Search for a product with missing image                               | Placeholder image shown                                      |
| TC5          | Missing product rating          | Search for a product with missing rating                              | Placeholder or "No rating" shown                             |
| TC6          | Invalid image URL               | Search for a product with invalid image URL                           | Placeholder image shown                                      |
| TC7          | Zero or negative price          | Search for a product with zero or negative price                      | Error or "Contact for price" shown                           |
| TC8          | Rating out of range             | Search for a product with rating outside valid range (e.g., 6/5)      | Error or corrected rating shown                              |
| TC9          | No products found               | Search with no matching products                                      | "No products found" message displayed                        |

---

### Test Plan Table

| Phase         | Activity                                  | Responsible | Output                          |
|---------------|-------------------------------------------|-------------|----------------------------------|
| Preparation   | Review requirements, prepare test data    | QA          | Test cases, test data            |
| Execution     | Run test cases in VS Code                 | QA          | Test results, bug reports        |
| Reporting     | Document results, report issues           | QA          | Test report, issue tracker update|
| Regression    | Re-test after fixes                       | QA          | Updated test results             |

---

### Test Data Table

| Product Name      | Price   | Image URL             | Rating | Notes                        |
|-------------------|---------|-----------------------|--------|------------------------------|
| Widget A          | $10.99  | valid_image.jpg       | 4.5    | All valid                    |
| Widget B          |         | valid_image.jpg       | 4.0    | Missing price                |
| Widget C          | $0.00   | valid_image.jpg       | 3.0    | Zero price                   |
| Widget D          | $15.99  |                       | 5.0    | Missing image                |
| Widget E          | $12.99  | invalid_url.jpg       | 2.0    | Invalid image URL            |
| Widget F          | $9.99   | valid_image.jpg       |        | Missing rating               |
| Widget G          | $8.99   | valid_image.jpg       | 6.0    | Rating out of range          |
|                   | $7.99   | valid_image.jpg       | 4.0    | Missing name                 |
| Widget H          | $-5.00  | valid_image.jpg       | 3.5    | Negative price               |