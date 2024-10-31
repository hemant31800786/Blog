
**Project Setup and Run Instructions ** -**Net 8 **

**1. Update appsettings.json:**

    Open appsettings.json.
    
    Modify the connection string as follows:
    
    "ConnectionStrings": {
        
                "EFUnitOfWork": "Server=(localdb)\\mssqllocaldb;Database=MVCBlog;Trusted_Connection=True;MultipleActiveResultSets=true;application name=MVCBlog"
    }
    
 **3. Build and Run the Project:**

     Build the project to ensure everything compiles correctly.
  
     Run the project to launch the application.

**2. Update the Database:**

    Go to Tools > NuGet Package Manager > Package Manager Console.
    
    Run the following command:
    
    **PM> update-database**

![{4EA6B4F0-764B-4220-8AAE-F3695A1FC268}](https://github.com/user-attachments/assets/ef460a77-13d4-4ebc-a6ac-8e561c2cbe6c)






**4. Add a New Blog:**

    Navigate to the "Add Blog" section to create a new blog entry.

![{5B1F354B-0CAE-45A3-97DE-43DBEDDAABF9}](https://github.com/user-attachments/assets/892ad7c9-97fd-4c33-9638-bb159c9dd2c1)

**5. Fill in Blog Data:**

        Enter the blog information as required.

![{EAF70EC9-37B5-4014-829C-F4AB15731553}](https://github.com/user-attachments/assets/22b791cf-bebd-4545-9535-be503e7ba04f)

**6. View Blog Entries:**

    View your blog entries to confirm that they were added successfully.

![{2179CFC3-4DA1-4F74-9B3F-E6D30A66976B}](https://github.com/user-attachments/assets/f0f3b852-1467-4a69-836a-52c2e707a0fc)

**7. Edit, Delete Blog, and Add Comments:**

    Use the available options to edit or delete a blog entry or to add a new comment to it.

![{47C56683-9860-41CA-82FC-6EE431B0E504}](https://github.com/user-attachments/assets/73dd9da6-675a-4df4-9d68-5b3459489d73)

**8. Edit or Delete Comments:**

    To manage comments, you can either edit or delete any existing comments.


![{C2EB2E1F-D796-4417-8CE0-481F5653D302}](https://github.com/user-attachments/assets/be3fad2d-7580-4b5c-aadb-195f28e4f749)




