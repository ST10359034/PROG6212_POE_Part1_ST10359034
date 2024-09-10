# Contract Monthly Claim System (CMCS)

## Overview

The Contract Monthly Claim System (CMCS) is a web-based application designed to streamline the process of submitting and approving monthly claims for Independent Contractor (IC) lecturers. Built using .NET Core MVC, the system provides an efficient and user-friendly interface for both lecturers and administrative staff.

## Design Choices

### Framework

I have chosen to use **Model-View-Controller (MVC) with .NET Core** as the framework for this project. MVC offers a clear separation of concerns, making it easier to manage and test the application. Additionally, .NET Core MVC is a modern framework well-suited for web-based applications, offering advantages over older frameworks like Windows Forms.

### Database Structure

The system uses a **relational database** with the following tables:

- **Lecturer**: Stores personal information such as names and emails.
- **Claim**: Contains details of each claim, including hours worked, date, status, and the associated lecturer.
- **Document**: Stores file paths for supporting documents and links them to relevant claims.
- **User**: Maintains login information for all users (lecturers, coordinators, and academic managers) and uses roles to define their permissions.

This structure ensures efficient data storage and retrieval, aligning with the needs of the application.

## Assumptions

- Claims are submitted by lecturers on a monthly basis.
- Each claim must be approved or rejected within a given timeframe set by academic managers and program coordinators.
- Claims are processed in a first-come, first-served manner.

## Constraints

- The system is designed to be user-friendly and require minimal training for operation.
- Once a claim is rejected, it cannot be resubmitted. However, lecturers can make corrections and submit the claim before the final approval.

