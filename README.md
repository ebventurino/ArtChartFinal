# ArtChartFinal


![alt text](/i.imgur.com/xWxwxkT.jpg "Logo Title Text 1")

Steps for using:

1. Clone down the ArtChartFinal repo

2. CD into the directory and Start ArtChart2.sln to open in Visual Studio

3. Make sure the database is set up in the Object Explorer. Do so by going to appsettings.json and changing :  

            "DefaultConnection": "Server=YOUR_SERVER_NAME_HERE\\SQLEXPRESS01;Database=ArtChart;Trusted_Connection=True;"
            
4. Run "update-database" in the Package Manager Console.
            
5. Hit ISS Express and that will start the app.

6. Register as a new User

7. Go to the "Artwork" tab in the application, and you will be able to create an entry for your artwork. You can also delete, edit, or see details of the art you submit.
