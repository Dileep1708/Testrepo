### User Story Details

| **Key**   | **Summary**            | **Description**                                                                                     | **Acceptance Criteria**                                                                                     |
|-----------|------------------------|-----------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------|
| PM-707    | Search suggestions     | Provide real-time search suggestions as the user types in the search bar.                          | 1. As the user types, a dropdown shows relevant product names or categories.                                |
|           |                        |                                                                                                     | 2. Selecting a suggestion populates the search bar and initiates a search.                                  |

---

### Test Cases

| **Test Case ID** | **Test Scenario**                                                                 | **Steps**                                                                                     | **Expected Result**                                                                                     |
|------------------|-----------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------|
| TC-001           | Verify dropdown shows suggestions as user types valid input                      | 1. Open search bar. <br> 2. Type "Laptop".                                                    | Dropdown displays relevant product names or categories (e.g., "Laptop", "Laptop Bags").                 |
| TC-002           | Verify selecting a suggestion populates the search bar and initiates a search     | 1. Type "Laptop". <br> 2. Select "Laptop Bags" from dropdown.                                 | Search bar is populated with "Laptop Bags", and search results for "Laptop Bags" are displayed.         |
| TC-003           | Verify no suggestions are shown for invalid input                                | 1. Type random characters (e.g., "xyz123").                                                   | Dropdown does not display any suggestions.                                                             |
| TC-004           | Verify dropdown updates dynamically as user continues typing                     | 1. Type "Lap". <br> 2. Continue typing "Laptop".                                              | Suggestions update dynamically to match the input.                                                     |
| TC-005           | Verify dropdown disappears when search bar is cleared                            | 1. Type "Laptop". <br> 2. Clear the search bar.                                               | Dropdown disappears when the search bar is cleared.                                                    |
| TC-006           | Verify dropdown disappears when user clicks outside the search bar               | 1. Type "Laptop". <br> 2. Click outside the search bar.                                       | Dropdown disappears.                                                                                   |
| TC-007           | Verify special characters do not break the search functionality                  | 1. Type special characters (e.g., "@#$%").                                                    | Dropdown handles input gracefully without errors.                                                      |
| TC-008           | Verify performance of suggestions for large datasets                             | 1. Type "Laptop" in a dataset with 1M+ products.                                              | Suggestions are displayed within 1 second.                                                             |

---

### Test Plan

| **Test Phase**       | **Objective**                                                                 | **Activities**                                                                                 | **Deliverables**                                                                                     |
|-----------------------|-------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------|
| Test Planning         | Define scope, objectives, and resources for testing                         | Create test cases, test data, and test environment.                                            | Test Plan Document, Test Cases.                                                                     |
| Test Execution        | Execute test cases for search suggestions                                   | Run positive and negative test cases in the integrated terminal of Visual Studio Code.         | Test Execution Report.                                                                              |
| Defect Reporting      | Log and track defects                                                       | Report issues in the bug tracking system.                                                      | Defect Log.                                                                                         |
| Regression Testing    | Ensure new changes do not break existing functionality                      | Re-run all test cases after fixes.                                                             | Regression Test Report.                                                                             |
| Performance Testing   | Validate performance of real-time suggestions                              | Test response time for large datasets.                                                         | Performance Test Report.                                                                            |

---

### Test Data

| **Input**            | **Expected Suggestions**                                                                 |
|----------------------|------------------------------------------------------------------------------------------|
| "Lap"               | "Laptop", "Laptop Bags", "Laptop Accessories".                                           |
| "Phone"             | "Phone Cases", "Smartphones", "Phone Chargers".                                          |
| "xyz123"            | No suggestions.                                                                          |
| "@#$%"              | No suggestions.                                                                          |
| "" (empty input)    | No suggestions.                                                                          |
| "Laptop" (large dataset) | Suggestions displayed within 1 second for relevant products.                          |### User Story Details

| **Key**   | **Summary**               | **Description**                                                                                     | **Acceptance Criteria**                                                                                     |
|-----------|---------------------------|-----------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------|
| PM-706    | Clear all filters option  | Allow users to clear all applied filters with a single action.                                      | A "Clear All" button is visible when filters are applied; clicking it removes all filters and refreshes the product list. |

---

### Test Cases

| **Test Case ID** | **Test Scenario**                                                                 | **Steps**                                                                                                                                       | **Expected Result**                                                                                   |
|-------------------|-----------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------|
| TC-001            | Verify "Clear All" button is visible when filters are applied                   | 1. Apply one or more filters. <br> 2. Check if the "Clear All" button is visible.                                                              | "Clear All" button should be visible.                                                                |
| TC-002            | Verify "Clear All" button clears all applied filters                            | 1. Apply multiple filters. <br> 2. Click the "Clear All" button.                                                                               | All filters should be removed, and the product list should refresh to show all items.                |
| TC-003            | Verify "Clear All" button is not visible when no filters are applied            | 1. Ensure no filters are applied. <br> 2. Check if the "Clear All" button is visible.                                                         | "Clear All" button should not be visible.                                                            |
| TC-004            | Verify product list refreshes after clearing filters                            | 1. Apply filters. <br> 2. Click the "Clear All" button. <br> 3. Observe the product list.                                                     | Product list should refresh and display all items.                                                   |
| TC-005            | Verify "Clear All" button functionality with invalid or corrupted filter states | 1. Apply filters. <br> 2. Simulate an invalid filter state (e.g., corrupted data). <br> 3. Click "Clear All".                                 | "Clear All" button should gracefully handle invalid states and reset filters without errors.          |
| TC-006            | Verify "Clear All" button accessibility                                         | 1. Apply filters. <br> 2. Use keyboard navigation or screen reader to interact with the "Clear All" button.                                   | "Clear All" button should be accessible via keyboard and screen readers.                             |

---

### Test Plan

| **Test Phase**       | **Objective**                                                                 | **Tasks**                                                                                              | **Owner**       | **Timeline** |
|-----------------------|-------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------|-----------------|--------------|
| Test Preparation      | Prepare test cases, test data, and environment setup                        | Write test cases, create test data, and configure the test environment.                                | QA Team         | Day 1        |
| Functional Testing    | Verify the functionality of the "Clear All" button                          | Execute positive and negative test cases.                                                              | QA Team         | Day 2-3      |
| Accessibility Testing | Ensure the "Clear All" button is accessible                                 | Test with keyboard navigation and screen readers.                                                      | Accessibility QA| Day 4        |
| Regression Testing    | Ensure no existing functionality is broken                                  | Run regression tests on related features (e.g., filter application and product list refresh).          | QA Team         | Day 5        |
| UAT                  | Validate the feature with end-users                                          | Conduct user acceptance testing with stakeholders.                                                     | Product Owner   | Day 6        |

---

### Test Data

| **Test Data ID** | **Filter Type**       | **Filter Value**       | **Expected Result**                                                                                   |
|-------------------|-----------------------|-------------------------|-------------------------------------------------------------------------------------------------------|
| TD-001            | Category Filter      | Electronics             | "Clear All" button should clear the category filter and refresh the product list.                    |
| TD-002            | Price Range Filter   | $50 - $100             | "Clear All" button should clear the price range filter and refresh the product list.                 |
| TD-003            | Brand Filter         | Samsung                | "Clear All" button should clear the brand filter and refresh the product list.                       |
| TD-004            | Multiple Filters     | Electronics, $50-$100  | "Clear All" button should clear all applied filters and refresh the product list.                    |
| TD-005            | No Filters Applied   | N/A                    | "Clear All" button should not be visible.                                                            |
| TD-006            | Invalid Filter State | Corrupted Data         | "Clear All" button should reset filters gracefully without errors and refresh the product list.      |### Tabulated Test Cases

| **Test Case ID** | **Test Scenario**                                      | **Steps**                                                                 | **Expected Result**                                                                 | **Type**       |
|-------------------|-------------------------------------------------------|---------------------------------------------------------------------------|------------------------------------------------------------------------------------|----------------|
| TC-001            | Display recent searches when search bar is clicked    | 1. Open the application.<br>2. Click on the search bar.                   | The last five search queries are displayed below the search bar.                  | Positive       |
| TC-002            | Populate search bar with selected query               | 1. Click on the search bar.<br>2. Select a query from the recent searches.| The selected query is populated in the search bar, and a search is triggered.     | Positive       |
| TC-003            | No recent searches available                          | 1. Open the application.<br>2. Click on the search bar.                   | A message like "No recent searches" is displayed if no searches exist.            | Negative       |
| TC-004            | Display only the last five searches                   | 1. Perform more than five searches.<br>2. Click on the search bar.        | Only the last five search queries are displayed.                                  | Positive       |
| TC-005            | Handle duplicate search queries                       | 1. Perform duplicate searches.<br>2. Click on the search bar.             | Duplicate queries are displayed as separate entries or handled as per requirements.| Positive/Edge  |
| TC-006            | Handle special characters in search queries           | 1. Search using special characters.<br>2. Click on the search bar.        | Special characters in search queries are displayed correctly.                     | Positive/Edge  |
| TC-007            | Handle empty search queries                           | 1. Perform an empty search.<br>2. Click on the search bar.                | Empty searches are not added to the recent searches list.                         | Negative       |
| TC-008            | Handle long search queries                            | 1. Perform a search with a long query.<br>2. Click on the search bar.     | Long queries are truncated or displayed fully as per the design.                  | Positive/Edge  |

---

### Tabulated Test Plan

| **Test Plan ID** | **Objective**                                      | **Scope**                                                                 | **Resources**               | **Timeline**       | **Risks**                        |
|-------------------|---------------------------------------------------|---------------------------------------------------------------------------|-----------------------------|--------------------|-----------------------------------|
| TP-001            | Validate recent search functionality              | Ensure recent searches are displayed, selectable, and functional.         | QA Engineers, Test Devices | 2 Weeks            | UI inconsistencies, data loss    |
| TP-002            | Test edge cases and error handling                | Validate handling of empty, duplicate, and special character searches.    | QA Engineers               | 1 Week             | Misalignment with requirements   |
| TP-003            | Performance testing                               | Ensure the feature works under heavy usage and large datasets.            | QA Engineers, Tools        | 1 Week             | Performance degradation          |

---

### Tabulated Test Data

| **Test Data ID** | **Input**                     | **Expected Output**                                                                 |
|-------------------|-------------------------------|-------------------------------------------------------------------------------------|
| TD-001            | ["apple", "banana", "carrot"]| Display "apple", "banana", "carrot" below the search bar.                          |
| TD-002            | []                            | Display "No recent searches" message.                                              |
| TD-003            | ["apple", "apple"]            | Display both "apple" entries or handle duplicates as per requirements.             |
| TD-004            | ["a", "b", "c", "d", "e", "f"]| Display only the last five queries: "b", "c", "d", "e", "f".                       |
| TD-005            | ["@#$%", "123"]               | Display "@#$%" and "123" correctly below the search bar.                           |
| TD-006            | [""]                          | Do not add empty search queries to the recent searches list.                       |
| TD-007            | ["longquery..."]              | Display the long query truncated or fully as per the design.                       |### User Story Details

| **Key**   | **Summary**                  | **Description**                                                                                     | **Acceptance Criteria**                                                                                                                                         |
|-----------|------------------------------|-----------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|
| PM-704    | Search Bar Implementation    | As a user, I want to search for products using a search bar so that I can quickly find what I need. | 1. The search bar should be prominently displayed on the homepage.<br>2. Users should be able to type keywords and see relevant product results.<br>3. The search results should update dynamically as the user types. |

---

### Test Cases

| **Test Case ID** | **Description**                                                                 | **Steps**                                                                                                                                         | **Expected Result**                                                                                     | **Type**       |
|-------------------|---------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------|----------------|
| TC-001            | Verify the search bar is displayed on the homepage                              | 1. Navigate to the homepage.<br>2. Check if the search bar is visible.                                                                            | The search bar is prominently displayed on the homepage.                                                | Positive       |
| TC-002            | Verify search results appear for valid keywords                                 | 1. Navigate to the homepage.<br>2. Enter a valid keyword (e.g., "laptop") in the search bar.<br>3. Observe the results.                           | Relevant product results are displayed.                                                                 | Positive       |
| TC-003            | Verify search results update dynamically as the user types                     | 1. Navigate to the homepage.<br>2. Start typing a keyword (e.g., "lap").<br>3. Observe the results updating dynamically.                          | Search results update dynamically as the user types.                                                    | Positive       |
| TC-004            | Verify no results message for invalid keywords                                 | 1. Navigate to the homepage.<br>2. Enter an invalid keyword (e.g., "xyz123").<br>3. Observe the results.                                          | A "No results found" message is displayed.                                                              | Negative       |
| TC-005            | Verify search bar handles special characters                                   | 1. Navigate to the homepage.<br>2. Enter special characters (e.g., "@#$%").<br>3. Observe the results.                                            | The system handles special characters gracefully (e.g., no crash, appropriate message if no results).   | Negative       |
| TC-006            | Verify search bar handles empty input                                          | 1. Navigate to the homepage.<br>2. Leave the search bar empty.<br>3. Press Enter or wait.                                                         | No results are displayed, and the system remains stable.                                                | Negative       |
| TC-007            | Verify search bar handles large input                                          | 1. Navigate to the homepage.<br>2. Enter a very long string (e.g., 500 characters).<br>3. Observe the results.                                    | The system handles large input gracefully (e.g., no crash, appropriate message if no results).          | Negative       |

---

### Test Plan

| **Test Phase**       | **Objective**                                                                                     | **Activities**                                                                                     | **Deliverables**                          |
|-----------------------|---------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------|-------------------------------------------|
| Test Planning         | Define the scope, objectives, and approach for testing the search bar implementation.            | Create test cases, test data, and test environment setup.                                           | Test Plan Document, Test Cases            |
| Test Case Execution   | Execute the test cases to validate the functionality of the search bar.                          | Run positive and negative test cases, log defects if any.                                           | Test Execution Report, Defect Logs        |
| Regression Testing    | Ensure existing functionality is not broken after implementing the search bar.                   | Re-run previously passed test cases.                                                               | Regression Test Report                    |
| User Acceptance Testing (UAT) | Validate the search bar meets user expectations and acceptance criteria.                  | Conduct testing with end-users or stakeholders.                                                    | UAT Sign-off                              |

---

### Test Data

| **Test Data ID** | **Input**               | **Purpose**                                                                                     | **Expected Result**                                                                                     |
|-------------------|-------------------------|-------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------|
| TD-001            | "laptop"               | Valid keyword to test search functionality.                                                    | Relevant product results are displayed.                                                                 |
| TD-002            | "xyz123"               | Invalid keyword to test "No results found" message.                                             | A "No results found" message is displayed.                                                              |
| TD-003            | "@#$%"                 | Special characters to test system handling.                                                    | The system handles special characters gracefully.                                                       |
| TD-004            | "" (empty input)       | Empty input to test system stability.                                                          | No results are displayed, and the system remains stable.                                                |
| TD-005            | Long string (500 chars)| Large input to test system handling of excessive input.                                         | The system handles large input gracefully.                                                              |