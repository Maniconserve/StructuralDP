// Create files
using CompositeDP;

IComponent file1 = new CompositeDP.File("Document.pdf");
IComponent file2 = new CompositeDP.File("Image.png");
IComponent file3 = new CompositeDP.File("Presentation.ppt");

// Create folders and add files
Folder root = new Folder("Root");
Folder subFolder1 = new Folder("Work");
Folder subFolder2 = new Folder("Personal");

root.Add(file1);
subFolder1.Add(file2);
subFolder2.Add(file3);

root.Add(subFolder1);
root.Add(subFolder2);

// Display the structure
root.Display(1);