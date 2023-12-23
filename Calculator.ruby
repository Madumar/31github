def add(x, y)
  x + y
end

def subtract(x, y)
  x - y
end

def multiply(x, y)
  x * y
end

def divide(x, y)
  if y.zero?
    puts "Error: Division by zero"
    return nil
  else
    x / y.to_f
  end
end

def calculator
  puts "Simple Calculator"
  puts "1. Addition"
  puts "2. Subtraction"
  puts "3. Multiplication"
  puts "4. Division"
  puts "5. Quit"

  print "Enter your choice (1-5): "
  choice = gets.chomp.to_i

  case choice
  when 1, 2, 3, 4
    print "Enter first number: "
    num1 = gets.chomp.to_f

    print "Enter second number: "
    num2 = gets.chomp.to_f

    case choice
    when 1
      result = add(num1, num2)
      operation = "Addition"
    when 2
      result = subtract(num1, num2)
      operation = "Subtraction"
    when 3
      result = multiply(num1, num2)
      operation = "Multiplication"
    when 4
      result = divide(num1, num2)
      operation = "Division"
    end

    if result
      puts "#{operation} result: #{result}"
    end

  when 5
    puts "Exiting the calculator. Goodbye!"

  else
    puts "Invalid choice. Please enter a number between 1 and 5."
  end
end

# Run the calculator
calculator
