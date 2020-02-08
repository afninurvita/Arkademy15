<?php include("config.php"); ?>

<!DOCTYPE html>
   <html>
   <head>
     <title></title>
     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
   </head>
   <body>
      <table class="table">
        <thead>
          <tr>
            <th scope="col">Name</th>
            <th scope="col">Work</th>
            <th scope="col">Salary</th>
            <th scope="col">Action</th>
          </tr>
        </thead>
        <tbody>

        <?php
          $sql = "SELECT * 
                  FROM 
                    name AS n
                    INNER JOIN work AS w ON(w.id = n.id_work) 
                    INNER JOIN salary AS s ON(s.id = n.id_salary)";

          $query = mysqli_query($db, $sql);

          while($worker = mysqli_fetch_array($query)){
              echo "<tr>";

              echo "<td>".$worker['nama']."</td>";
              echo "<td>".$worker['name']."</td>";
              echo "<td>".$worker['salary']."</td>";
              echo "<td>";
              echo "<a href='form-edit.php?id=".$worker['id']."'>Edit</a> | ";
              echo "<a href='hapus.php?id=".$worker['id']."'>Hapus</a>";
              echo "</td>";

              echo "</tr>";
          }
        ?>
        </tbody>
      </table>

      <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
      <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
      <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
   </body>
   </html>   