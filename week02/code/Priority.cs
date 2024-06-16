public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Single enqueue and dequeue
        // Expected Result: A
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("A", 1);
        var result1 = priorityQueue.Dequeue();
        Console.WriteLine(result1);

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Multiple enqueues and single dequeue
        // Expected Result: B
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 1);
        var result2 = priorityQueue.Dequeue();
        Console.WriteLine(result2);
        Console.WriteLine("---------");


        // Test 3
        // Scenario: Dequeue with same priority, FIFO order
        // Expected Result: D
        Console.WriteLine("Test 3");
        priorityQueue.Enqueue("D", 3);
        priorityQueue.Enqueue("E", 3);
        var result3 = priorityQueue.Dequeue();
        Console.WriteLine(result3);
        Console.WriteLine("---------");



        // Test 4
        // Scenario: Empty queue dequeue
        // Expected Result: The queue is empty.

        Console.WriteLine("Test 4");
        priorityQueue = new PriorityQueue();
        var result4 = priorityQueue.Dequeue();

        Console.WriteLine("---------");




        // Test 5
        // Scenario: Complex enqueue and dequeue
        // Expected Result: G
        Console.WriteLine("Test 5");
        priorityQueue.Enqueue("F", 2);
        priorityQueue.Enqueue("G", 5);
        priorityQueue.Enqueue("H", 1);
        var result5 = priorityQueue.Dequeue();
        Console.WriteLine(result5);
        Console.WriteLine("---------");

    }
}