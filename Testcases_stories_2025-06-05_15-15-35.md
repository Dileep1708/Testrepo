### User Story Details

| **Key**       | **Summary**             | **Description**                                                                                     | **Acceptance Criteria**                                                                 |
|---------------|-------------------------|-----------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------|
| **PM1-926**   | Add Products to Cart    | As a logged-in user, I want to add multiple products to my shopping cart so that I can purchase them later. | Users can add products to the cart, and the cart updates with the selected items.      |

---

### Test Cases

| **Test Case ID** | **Scenario**                              | **Steps**                                                                                     | **Expected Result**                                                                 |
|------------------|-------------------------------------------|-----------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------|
| TC1              | Add a single product to the cart         | 1. Log in as a user. <br> 2. Navigate to a product page. <br> 3. Click "Add to Cart".          | Product is added to the cart, and the cart updates with the selected item.         |
| TC2              | Add multiple products to the cart        | 1. Log in as a user. <br> 2. Navigate to multiple product pages. <br> 3. Add each product to the cart. | All selected products are added to the cart, and the cart updates accordingly.     |
| TC3              | Add the same product multiple times      | 1. Log in as a user. <br> 2. Navigate to a product page. <br> 3. Add the same product multiple times. | The cart reflects the correct quantity of the product added.                       |
| TC4              | Add product without logging in           | 1. Navigate to a product page without logging in. <br> 2. Click "Add to Cart".                | User is prompted to log in before adding the product to the cart.                  |
| TC5              | Add an out-of-stock product              | 1. Log in as a user. <br> 2. Navigate to an out-of-stock product page. <br> 3. Click "Add to Cart". | User is notified that the product is out of stock and cannot be added to the cart. |
| TC6              | Verify cart updates after adding products | 1. Log in as a user. <br> 2. Add products to the cart. <br> 3. Navigate to the cart page.      | The cart displays all added products with correct quantities and prices.           |

---

### Test Plan

| **Test Plan ID** | **Objective**                          | **Scope**                                                                 | **Approach**                                                                 |
|------------------|----------------------------------------|---------------------------------------------------------------------------|------------------------------------------------------------------------------|
| TP1              | Validate adding products to the cart  | Ensure logged-in users can add products to the cart and the cart updates. | Execute positive and negative test cases to verify functionality and edge cases. |
| TP2              | Verify cart behavior                  | Ensure the cart reflects correct quantities, prices, and updates.         | Test cart updates after adding, removing, or modifying products.            |
| TP3              | Validate user authentication          | Ensure only logged-in users can add products to the cart.                 | Test scenarios with logged-in and non-logged-in users.                      |

---

### Test Data

| **Test Data ID** | **Field**          | **Value**                                                                 |
|------------------|--------------------|---------------------------------------------------------------------------|
| TD1              | Product Name       | "Laptop", "Smartphone", "Headphones"                                      |
| TD2              | Product Quantity   | 1, 2, 5                                                                  |
| TD3              | Product Status     | In-stock, Out-of-stock                                                   |
| TD4              | User Status        | Logged-in, Not logged-in                                                 |
| TD5              | Cart Initial State | Empty, Contains products                                                 |