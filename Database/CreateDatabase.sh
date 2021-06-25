echo "creating database for $Reusable"

rm -rf ./Script.sql

echo "create database $Reusable" >> ./Script.sql
echo "go" >> ./Script.sql

for i in {1..50};
do
    /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P lksU2o412f7tBj58t07B -d master -i ./Script.sql
    if [ $? -eq 0 ]
    then
        echo "database $Reusable is created"
        break
    else
        echo "waiting for SQL Server..."
        sleep 1
    fi
done
