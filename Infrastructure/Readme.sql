CREATE TABLE Company (
                         company_id INT PRIMARY KEY,
                         company_name VARCHAR(255) NOT NULL,
                         company_address VARCHAR(255)
);

CREATE TABLE Department (
                            department_id INT PRIMARY KEY,
                            department_name VARCHAR(255) NOT NULL,
                            company_id INT REFERENCES Company(company_id)
);

CREATE TABLE Branch (
                        branch_id INT PRIMARY KEY,
                        branch_name VARCHAR(255) NOT NULL,
                        department_id INT REFERENCES Department(department_id)
);

CREATE TABLE Employee (
                          employee_id INT PRIMARY KEY,
                          first_name VARCHAR(255) NOT NULL,
                          last_name VARCHAR(255) NOT NULL,
                          position VARCHAR(255),
                          branch_id INT REFERENCES Branch(branch_id),
                          department_id INT REFERENCES Department(department_id)
);

