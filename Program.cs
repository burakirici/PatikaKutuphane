﻿using PatikaKutuphane;

Library book1 = new Library()
{
    Name = "Bir Kitap",
    AuthorName = "Ahmet",
    AuthorSurname = "Yılmaz",
    PageNumb = 320,
    Publisher = "Alfa Yayınları"
};

Console.WriteLine("Book Name: " + book1.Name + "\nAuthor Name: " + book1.AuthorName + "\nAuthor Surname: " + book1.AuthorSurname + "\nPage Numbers: " + book1.PageNumb + "\nPublisher: " + book1.Publisher);
Library.BookCount_++;
Library book2 = new("Başka Bir Kitap", "Ayşe", "Karan", 215, "Beta Yayıncılık");
Console.WriteLine("Book Name: " + book2.Name + "\nAuthor Name: " + book2.AuthorName + "\nAuthor Surname: " + book2.AuthorSurname + "\nPage Numbers: " + book2.PageNumb + "\nPublisher: " + book2.Publisher);
Library.BookCount_++;
Library.DisplayBookNumber();

// Class burada yeni bir Kütüphane sınıfı oluşturmak için kullanılır.
// Property burada yarattığımız Kütüphanedeki kitapların özelliklerini belirlemek için kullanılır.
// New burada kütüphaneye yeni kitaplar eklememizi sağlar.
// Constructor 2 adet alternatifle, biri default biri değer döndürecek şekilde kullanılmıştır. Oluşturduğumuz kitap nesnesiyle ilgili işlemleri yapabilmemizi sağlar. 

