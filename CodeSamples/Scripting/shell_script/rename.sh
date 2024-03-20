ls -lrt ~/Desktop/shell_script/files | awk -F " " '{print $9}' > temp.txt
for i in `cat temp.txt`
do
    #echo '/files/'$i
    mv './files/'$i './files/'$i.bin
done 