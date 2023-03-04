while ($true) {
  Write-Host "+ : Add"
  Write-Host "- : Subtract"
  Write-Host "* : Multiply"
  Write-Host "/ : Divide"
  $op = Read-Host "Choose an operator"

  $no1 = [float] (Read-Host "Enter first number")
  $no2 = [float] (Read-Host "Enter second number")

  switch ($op) {
    "+" {
      $result = $no1 + $no2
      Write-Host "Your result: $no1 + $no2 = $result"
    }
    "-" {
      $result = $no1 - $no2
      Write-Host "Your result: $no1 - $no2 = $result"
    }
    "*" {
      $result = $no1 * $no2
      Write-Host "Your result: $no1 * $no2 = $result"
    }
    "/" {
      $result = $no1 / $no2
      Write-Host "Your result: $no1 / $no2 = $result"
    }
  }

  $restart = Read-Host "Would you like to restart? y/n"
  if ($restart -ne "y") {
    break
  }
}