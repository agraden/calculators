while True:
    print("\t+ : Add")
    print("\t- : Subtract")
    print("\t* : Multiple")
    print("\t/ : Divide")
    op = input("\tChoose an operator: ")

    no1 = float(input("Enter first number: "))
    no2 = float(input("Enter second number: "))

    if op == "+":
        result = no1 + no2
        print(f"Your result: {no1} + {no2} = {result}")
    elif op == "-":
        result = no1 - no2
        print(f"Your result: {no1} - {no2} = {result}")
    elif op == "*":
        result = no1 * no2
        print(f"Your result: {no1} * {no2} = {result}")
    elif op == "/":
        result = no1 / no2
        print(f"Your result: {no1} / {no2} = {result}")
    else:
        print("Invalid entry")

    restart = input("Would you like to restart? y/n: ")
    if restart != "y":
        break
