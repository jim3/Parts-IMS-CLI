using System.Data.SQLite;

namespace InventoryManagementSystem {
    class Program {
        static void Main(string[] args) {
            Console.BackgroundColor = ConsoleColor.Black;  // changes the color of the background 
            Console.ForegroundColor = ConsoleColor.Cyan;  // changes the color of the text
            // Console.Clear();  // clears the console
            Console.WriteLine();
            Console.Write("\t\t");
            Console.Write(" Inventory Management System ");
            Console.WriteLine();
            Console.WriteLine();

            // Menu loop for the user to select an option
            int choice = 0;
            while (choice != 5) {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Create a part");
                Console.WriteLine("2. Read a part");
                Console.WriteLine("3. Update a part");
                Console.WriteLine("4. Delete a part");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string input = Console.ReadLine() ?? "";

                if (!int.TryParse(input, out choice)) {
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    continue;
                }

                switch (choice) {
                    case 1:
                        CreatePart();
                        break;
                    case 2:
                        ReadPart();
                        break;
                    case 3:
                        UpdatePart();
                        break;
                    case 4:
                        DeletePart();
                        break;
                    case 5:
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        break;
                }
            }
        }

        // Create a new part
        static void CreatePart() {
            Console.WriteLine("Creating a new part...\n");
        }

        // Read parts from the database
        static void ReadPart() {
            Console.WriteLine("Reading data from parts.db...\n");
            using (var connection = new SQLiteConnection("Data Source=parts.db")) {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT * FROM parts", connection)) {
                    using (var reader = command.ExecuteReader()) {
                        try {
                            while (reader.Read()) {
                                Console.WriteLine("part_id: " + reader.GetInt32(0) + ", " +
                                    "part_category: " + reader.GetString(1) + ", " +
                                    "part_type: " + reader.GetString(2) + ", " +
                                    "quantity: " + reader.GetInt32(3) + ", " +
                                    "price: " + reader.GetInt32(4));
                            }
                        } catch (Exception e) {
                            Console.WriteLine(e);
                        }
                    }
                }
            }
        }

        // Update a part
        static void UpdatePart() {
            Console.WriteLine("Updating a part...\n");
        }

        // Delete a part
        static void DeletePart() {
            Console.WriteLine("Deleting a part...\n");
        }

        // Exit the program
        static void Exit() {
            Console.WriteLine("Exiting...");
            Environment.Exit(0);
        }
    }
}
