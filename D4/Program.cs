﻿//string inputs = "2-4,6-8\r\n2-3,4-5\r\n5-7,7-9\r\n2-8,3-7\r\n6-6,4-6\r\n2-6,4-8";
string inputs = "18-20,19-21\r\n9-86,9-87\r\n7-8,8-18\r\n82-98,98-99\r\n17-17,17-77\r\n13-21,20-79\r\n46-52,45-46\r\n34-54,37-53\r\n4-91,3-5\r\n9-80,5-83\r\n66-83,67-83\r\n1-5,1-1\r\n24-27,23-23\r\n3-91,5-90\r\n20-81,19-20\r\n93-99,15-94\r\n1-86,1-87\r\n95-99,16-96\r\n5-94,93-94\r\n93-95,61-94\r\n2-87,2-86\r\n11-97,11-96\r\n2-49,50-78\r\n54-59,2-55\r\n7-96,8-97\r\n28-29,29-93\r\n8-86,8-55\r\n38-54,38-64\r\n97-97,44-96\r\n20-88,21-89\r\n57-80,58-80\r\n34-39,32-35\r\n7-73,8-73\r\n40-62,39-62\r\n50-52,51-51\r\n25-79,24-26\r\n13-84,12-85\r\n47-83,47-84\r\n49-77,76-77\r\n11-53,30-52\r\n85-86,86-86\r\n61-78,46-79\r\n19-52,20-92\r\n10-66,65-66\r\n90-92,13-91\r\n49-88,87-88\r\n44-79,45-80\r\n34-57,34-58\r\n68-70,52-69\r\n2-5,6-85\r\n19-74,18-75\r\n12-99,12-96\r\n95-95,45-96\r\n27-74,23-26\r\n86-90,88-88\r\n39-96,40-97\r\n42-49,43-55\r\n23-42,5-75\r\n3-86,1-93\r\n3-24,25-36\r\n76-80,8-76\r\n26-38,25-97\r\n27-39,16-38\r\n33-77,34-77\r\n64-81,13-63\r\n3-4,4-98\r\n52-80,42-51\r\n90-91,16-96\r\n16-56,45-47\r\n30-99,1-31\r\n51-96,10-51\r\n44-82,44-81\r\n3-53,2-64\r\n51-71,19-67\r\n5-80,80-96\r\n59-61,60-98\r\n84-84,77-85\r\n23-78,22-78\r\n43-84,14-82\r\n67-92,66-68\r\n10-98,23-96\r\n33-57,33-41\r\n20-72,19-71\r\n33-98,21-34\r\n32-55,55-97\r\n7-88,5-96\r\n28-76,3-28\r\n13-39,12-38\r\n19-26,30-71\r\n24-99,83-83\r\n90-96,66-76\r\n5-10,11-96\r\n10-92,15-90\r\n25-89,39-90\r\n13-97,12-97\r\n3-97,98-99\r\n4-6,5-97\r\n15-33,32-33\r\n4-42,10-71\r\n22-93,92-94\r\n22-84,7-16\r\n29-34,26-35\r\n11-66,11-85\r\n6-38,1-7\r\n47-93,5-92\r\n2-97,97-99\r\n6-55,54-86\r\n24-90,89-90\r\n10-79,10-57\r\n58-59,59-60\r\n44-55,45-56\r\n4-88,4-87\r\n99-99,2-96\r\n4-40,41-66\r\n86-92,15-85\r\n50-82,81-92\r\n4-77,5-78\r\n2-98,97-98\r\n4-34,35-35\r\n12-52,22-36\r\n46-47,46-47\r\n17-89,14-97\r\n52-66,65-66\r\n43-51,51-88\r\n26-68,27-68\r\n67-99,3-66\r\n38-92,93-95\r\n94-94,6-70\r\n7-93,29-95\r\n3-88,1-4\r\n82-83,68-83\r\n45-74,31-74\r\n2-95,37-94\r\n26-93,69-88\r\n81-82,74-82\r\n1-35,36-64\r\n3-70,4-70\r\n84-90,83-89\r\n48-65,23-48\r\n32-76,31-76\r\n30-86,31-85\r\n3-6,1-3\r\n49-80,49-79\r\n47-88,48-88\r\n2-13,3-14\r\n41-73,40-74\r\n67-92,67-88\r\n10-85,9-85\r\n14-87,13-87\r\n15-23,15-24\r\n35-56,57-73\r\n48-78,47-85\r\n13-99,6-13\r\n7-9,7-12\r\n3-85,13-51\r\n17-42,18-43\r\n24-68,23-47\r\n18-71,17-71\r\n5-33,4-4\r\n21-22,22-96\r\n16-83,82-97\r\n1-15,14-16\r\n2-2,2-2\r\n4-50,3-4\r\n73-97,73-98\r\n4-95,4-59\r\n18-62,18-99\r\n74-80,73-80\r\n2-62,3-43\r\n3-75,1-18\r\n72-74,21-73\r\n6-98,6-99\r\n3-98,1-3\r\n7-73,6-74\r\n7-77,6-77\r\n10-69,10-34\r\n21-92,20-93\r\n54-60,99-99\r\n9-83,1-3\r\n16-17,17-59\r\n5-81,3-96\r\n39-81,40-81\r\n57-87,3-86\r\n42-95,94-95\r\n53-60,51-61\r\n25-25,23-24\r\n12-66,11-67\r\n27-54,27-88\r\n14-30,30-92\r\n41-48,40-48\r\n27-58,42-59\r\n2-12,13-46\r\n53-54,18-53\r\n59-61,60-60\r\n21-80,2-84\r\n2-37,36-87\r\n14-85,13-86\r\n9-38,8-8\r\n83-97,99-99\r\n3-90,94-98\r\n17-97,16-16\r\n15-18,16-19\r\n13-90,13-89\r\n60-91,60-91\r\n47-85,86-91\r\n65-72,4-66\r\n4-44,45-82\r\n97-98,9-98\r\n18-97,18-47\r\n24-49,14-64\r\n38-85,37-97\r\n40-90,35-56\r\n23-91,6-99\r\n19-97,29-97\r\n9-90,8-89\r\n96-98,44-81\r\n48-59,37-59\r\n60-75,26-59\r\n30-99,30-79\r\n13-45,12-12\r\n9-24,25-94\r\n30-61,16-51\r\n56-97,56-80\r\n1-55,4-93\r\n3-99,12-94\r\n32-74,32-32\r\n31-35,20-34\r\n61-90,61-88\r\n20-57,56-91\r\n1-93,5-92\r\n1-94,1-95\r\n8-93,3-7\r\n10-12,13-55\r\n15-30,31-85\r\n81-84,82-85\r\n59-75,58-75\r\n6-78,77-79\r\n17-26,17-35\r\n34-67,66-67\r\n47-53,54-54\r\n22-98,23-98\r\n74-89,51-80\r\n47-59,45-47\r\n95-96,11-96\r\n1-47,1-37\r\n86-87,87-87\r\n32-32,32-33\r\n77-84,55-98\r\n85-85,12-85\r\n39-79,39-78\r\n61-88,11-61\r\n58-59,59-91\r\n82-90,5-90\r\n2-99,1-99\r\n17-96,64-96\r\n31-89,88-90\r\n81-83,6-82\r\n52-80,27-51\r\n59-68,60-67\r\n67-69,68-91\r\n17-87,18-87\r\n22-99,11-92\r\n3-98,4-98\r\n76-94,95-96\r\n63-99,64-72\r\n14-19,19-22\r\n67-68,67-69\r\n29-97,29-98\r\n2-51,1-3\r\n3-83,1-86\r\n3-64,4-39\r\n6-53,52-98\r\n67-69,22-69\r\n84-88,5-87\r\n23-28,28-82\r\n21-96,12-98\r\n24-91,90-95\r\n19-94,2-98\r\n29-91,30-86\r\n15-98,14-99\r\n12-47,20-66\r\n11-86,12-87\r\n66-90,39-66\r\n77-94,65-94\r\n63-81,64-81\r\n5-67,6-82\r\n47-49,44-48\r\n52-93,94-94\r\n53-86,25-87\r\n27-27,17-72\r\n26-94,40-77\r\n27-27,12-26\r\n17-90,18-91\r\n33-78,77-79\r\n79-97,96-99\r\n67-68,52-68\r\n5-63,1-6\r\n20-34,10-35\r\n54-81,82-82\r\n28-99,29-98\r\n9-89,91-94\r\n6-94,5-94\r\n37-40,19-41\r\n52-77,14-77\r\n35-45,48-99\r\n21-66,53-65\r\n30-33,29-29\r\n12-72,3-84\r\n62-84,19-58\r\n34-54,81-83\r\n20-98,21-93\r\n7-72,19-93\r\n88-90,12-89\r\n2-48,2-23\r\n4-94,3-93\r\n38-58,14-39\r\n85-86,53-86\r\n10-78,1-11\r\n30-30,31-60\r\n38-91,32-82\r\n83-85,82-84\r\n40-82,82-83\r\n24-29,19-74\r\n24-70,25-69\r\n56-69,56-71\r\n32-84,26-85\r\n3-98,97-99\r\n11-90,10-89\r\n48-75,49-75\r\n17-95,18-45\r\n31-79,72-74\r\n4-4,5-89\r\n76-91,57-77\r\n9-80,88-89\r\n61-91,60-91\r\n35-86,35-85\r\n56-66,57-67\r\n58-69,55-58\r\n65-90,43-66\r\n47-72,46-48\r\n7-14,5-6\r\n92-97,36-90\r\n11-49,11-64\r\n32-44,43-45\r\n18-74,19-75\r\n68-82,31-56\r\n62-90,59-91\r\n21-93,93-98\r\n13-18,17-61\r\n7-94,7-8\r\n7-10,10-71\r\n1-92,2-92\r\n9-12,15-70\r\n31-56,14-49\r\n14-93,15-90\r\n56-79,6-57\r\n7-96,6-28\r\n13-96,8-45\r\n24-44,43-44\r\n13-77,68-77\r\n28-96,28-97\r\n15-96,92-94\r\n7-43,7-42\r\n23-40,23-26\r\n58-96,59-96\r\n76-76,75-96\r\n30-56,29-31\r\n80-97,79-96\r\n21-49,21-48\r\n3-75,23-75\r\n4-6,7-96\r\n56-91,7-55\r\n2-14,15-70\r\n35-62,27-34\r\n64-93,63-63\r\n10-10,11-18\r\n1-69,1-70\r\n97-98,1-98\r\n50-92,31-91\r\n12-12,13-59\r\n89-92,14-90\r\n14-15,14-15\r\n81-85,4-99\r\n20-84,13-89\r\n19-32,32-72\r\n35-39,37-40\r\n32-64,33-64\r\n39-67,68-75\r\n47-55,46-48\r\n36-67,35-67\r\n4-20,3-19\r\n33-70,52-69\r\n1-98,3-96\r\n17-74,16-74\r\n83-98,84-97\r\n12-36,12-29\r\n68-84,1-17\r\n15-63,14-63\r\n55-56,13-63\r\n9-62,61-63\r\n11-36,5-12\r\n23-81,4-85\r\n18-78,77-78\r\n4-95,3-97\r\n42-75,42-64\r\n7-97,5-7\r\n17-90,16-16\r\n6-85,2-88\r\n13-14,14-96\r\n52-61,53-62\r\n38-42,34-43\r\n30-31,23-32\r\n7-95,6-94\r\n94-95,49-65\r\n18-97,17-96\r\n7-87,8-88\r\n33-33,34-54\r\n56-68,55-78\r\n11-46,10-46\r\n3-96,2-95\r\n69-69,63-70\r\n67-83,84-84\r\n45-74,37-75\r\n1-3,4-41\r\n7-98,8-99\r\n9-31,10-32\r\n64-65,65-79\r\n28-30,12-29\r\n2-70,69-71\r\n2-94,4-29\r\n84-89,16-83\r\n4-33,5-48\r\n52-91,52-95\r\n43-48,17-47\r\n56-58,57-60\r\n12-92,8-13\r\n68-97,39-69\r\n31-33,36-78\r\n1-95,96-96\r\n47-55,48-55\r\n98-98,2-99\r\n8-76,75-77\r\n9-43,5-25\r\n15-73,57-73\r\n28-42,28-40\r\n16-19,13-20\r\n15-28,29-29\r\n12-74,65-73\r\n55-93,3-93\r\n51-76,56-61\r\n37-77,61-76\r\n9-94,9-24\r\n24-49,49-76\r\n29-33,28-66\r\n43-53,33-54\r\n47-95,35-95\r\n60-73,61-74\r\n48-85,47-47\r\n48-68,18-48\r\n18-81,18-92\r\n4-97,3-5\r\n15-16,15-29\r\n5-9,8-91\r\n77-87,16-76\r\n23-99,22-98\r\n3-64,63-99\r\n5-86,91-93\r\n5-80,1-85\r\n6-54,6-46\r\n42-90,47-80\r\n43-45,44-79\r\n9-66,10-67\r\n88-89,6-89\r\n44-71,45-72\r\n21-86,85-86\r\n59-59,60-91\r\n17-95,18-99\r\n49-93,45-49\r\n36-86,37-81\r\n30-73,73-81\r\n42-46,38-56\r\n16-96,15-95\r\n3-30,4-35\r\n18-93,18-94\r\n14-23,13-45\r\n25-68,7-24\r\n36-55,28-90\r\n17-17,18-98\r\n3-91,3-91\r\n36-66,35-66\r\n1-77,2-77\r\n54-70,21-93\r\n26-73,26-64\r\n15-26,27-96\r\n31-48,48-82\r\n22-64,21-64\r\n74-99,54-73\r\n24-26,25-67\r\n24-24,25-88\r\n25-25,26-63\r\n24-81,80-87\r\n17-19,11-18\r\n19-88,87-88\r\n4-7,6-93\r\n54-71,72-72\r\n61-89,64-76\r\n96-98,36-97\r\n50-64,64-69\r\n66-93,97-99\r\n8-83,9-84\r\n5-96,6-96\r\n3-62,4-69\r\n74-94,52-95\r\n23-57,5-28\r\n9-93,10-93\r\n18-29,17-29\r\n67-85,16-31\r\n13-89,4-13\r\n36-75,15-36\r\n70-96,2-97\r\n20-29,28-93\r\n25-79,24-79\r\n25-92,17-93\r\n21-23,22-70\r\n33-74,34-75\r\n90-90,69-91\r\n39-95,38-95\r\n5-11,4-11\r\n35-36,36-94\r\n11-78,10-90\r\n56-85,57-86\r\n26-39,38-41\r\n2-99,3-99\r\n66-68,11-67\r\n39-85,81-81\r\n2-3,2-60\r\n20-32,20-31\r\n30-78,5-79\r\n14-74,7-82\r\n38-40,39-78\r\n53-55,54-67\r\n9-38,8-38\r\n3-99,2-99\r\n6-12,11-73\r\n96-96,91-95\r\n30-32,25-32\r\n80-81,4-81\r\n6-48,7-48\r\n11-54,2-12\r\n35-71,56-86\r\n41-65,40-66\r\n58-90,58-91\r\n53-87,25-87\r\n2-57,27-56\r\n5-65,4-66\r\n8-51,7-51\r\n84-98,18-28\r\n47-99,47-47\r\n64-71,70-78\r\n93-99,57-93\r\n70-72,1-71\r\n67-68,96-97\r\n31-61,51-52\r\n27-79,27-79\r\n50-77,51-78\r\n3-36,35-89\r\n90-91,18-91\r\n59-96,35-93\r\n14-58,13-13\r\n4-4,5-83\r\n10-33,10-21\r\n34-97,34-52\r\n13-99,98-99\r\n15-78,72-79\r\n7-51,4-35\r\n31-46,31-47\r\n41-59,41-60\r\n1-27,15-17\r\n50-83,63-97\r\n16-48,47-48\r\n8-70,69-99\r\n61-85,61-78\r\n3-87,2-3\r\n9-88,9-88\r\n19-21,8-29\r\n15-94,20-88\r\n1-83,1-84\r\n31-32,32-49\r\n2-5,4-27\r\n20-72,68-71\r\n63-64,50-63\r\n4-97,13-93\r\n3-68,88-96\r\n4-98,3-97\r\n20-20,21-34\r\n12-95,43-83\r\n32-33,33-71\r\n17-83,82-83\r\n31-36,25-32\r\n72-78,12-73\r\n70-81,69-69\r\n41-44,43-65\r\n82-82,18-81\r\n6-90,1-6\r\n6-11,6-11\r\n45-45,17-44\r\n10-87,9-9\r\n48-60,47-60\r\n28-73,28-73\r\n2-9,9-95\r\n41-98,97-99\r\n2-89,88-90\r\n1-93,2-93\r\n76-92,66-75\r\n1-70,26-70\r\n5-5,6-98\r\n24-82,49-61\r\n10-25,13-26\r\n13-22,17-21\r\n98-99,48-96\r\n1-83,3-99\r\n18-37,35-39\r\n4-99,15-99\r\n72-73,5-73\r\n7-99,8-99\r\n1-1,2-32\r\n39-89,39-88\r\n33-34,7-34\r\n76-79,74-79\r\n4-48,4-47\r\n6-96,16-93\r\n1-90,90-91\r\n2-99,54-86\r\n37-84,38-83\r\n5-5,6-99\r\n39-92,91-92\r\n71-73,19-72\r\n33-99,33-93\r\n10-16,15-88\r\n9-22,9-48\r\n11-38,18-37\r\n7-85,82-82\r\n7-33,6-33\r\n13-43,14-44\r\n16-43,15-15\r\n11-69,22-43\r\n10-94,10-93\r\n1-33,27-99\r\n25-44,32-42\r\n78-94,50-96\r\n23-85,27-87\r\n31-90,91-91\r\n50-52,51-52\r\n2-54,20-52\r\n64-82,65-82\r\n8-90,8-89\r\n34-88,35-89\r\n34-73,14-78\r\n22-25,26-76\r\n74-77,66-76\r\n85-89,25-85\r\n9-47,8-47\r\n29-93,28-92\r\n15-17,11-16\r\n82-85,2-81\r\n66-77,10-74\r\n3-46,6-25\r\n17-48,17-49\r\n93-98,94-99\r\n86-86,39-85\r\n15-97,33-98\r\n22-63,21-22\r\n36-81,37-82\r\n53-66,51-54\r\n87-94,10-88\r\n32-79,31-79\r\n15-67,66-67\r\n10-85,7-86\r\n25-37,25-93\r\n4-89,2-3\r\n35-76,35-86\r\n3-95,1-3\r\n6-99,5-57\r\n46-50,49-70\r\n19-56,19-89\r\n38-75,52-76\r\n13-48,12-47\r\n18-96,4-18\r\n2-95,1-96\r\n2-95,94-99\r\n32-41,31-42\r\n48-58,20-78\r\n57-86,16-70\r\n15-15,16-61\r\n98-99,6-97\r\n35-93,34-92\r\n57-57,58-87\r\n2-61,2-97\r\n7-96,59-96\r\n27-84,27-91\r\n30-98,29-97\r\n90-92,90-91\r\n3-70,3-71\r\n37-69,36-38\r\n35-51,45-52\r\n22-66,1-22\r\n4-90,2-3\r\n67-77,68-90\r\n11-70,7-11\r\n70-78,55-69\r\n96-97,4-97\r\n11-97,12-98\r\n48-55,47-54\r\n20-82,20-51\r\n44-45,45-57\r\n27-88,27-68\r\n98-99,13-99\r\n40-84,40-91\r\n3-69,1-73\r\n51-69,49-50\r\n4-53,2-2\r\n4-11,11-23\r\n2-99,4-97\r\n50-50,49-49\r\n64-94,53-95\r\n2-90,5-16\r\n14-96,53-97\r\n8-76,6-46\r\n35-84,12-36\r\n5-97,96-96\r\n58-65,3-89\r\n11-91,32-86\r\n27-89,26-26\r\n3-85,84-84\r\n37-52,51-91\r\n45-56,44-56\r\n21-22,22-84\r\n3-31,31-55\r\n52-89,88-90\r\n67-84,85-85\r\n31-75,76-76\r\n69-78,77-78\r\n22-84,71-95\r\n32-36,32-36\r\n4-92,91-93\r\n4-99,2-4\r\n87-88,59-88\r\n42-88,41-41\r\n43-54,20-54\r\n48-49,22-49\r\n30-63,29-44\r\n11-93,10-10\r\n61-87,14-61\r\n92-94,4-93\r\n94-98,32-94\r\n41-69,40-63\r\n77-78,32-78\r\n7-25,7-24\r\n94-95,2-93\r\n18-79,34-65\r\n47-88,89-94\r\n29-73,96-96\r\n22-58,58-98\r\n9-95,94-98\r\n43-66,66-89\r\n11-70,11-70\r\n9-79,10-80\r\n22-33,12-58\r\n42-73,42-74\r\n1-87,2-87\r\n2-20,3-75\r\n14-61,15-62\r\n17-18,9-18\r\n8-95,9-96\r\n94-95,7-95\r\n9-79,89-91\r\n2-98,48-55\r\n1-3,3-43\r\n25-73,25-90\r\n1-77,1-77\r\n13-97,12-96\r\n97-98,33-83\r\n55-80,24-80\r\n84-93,59-89\r\n8-56,7-55\r\n17-94,93-95\r\n54-90,54-89\r\n62-63,24-61\r\n66-67,66-67\r\n37-41,42-62\r\n13-94,12-94\r\n8-73,8-82\r\n14-53,39-53\r\n49-60,24-46\r\n24-91,13-23\r\n84-97,2-96\r\n19-85,20-86\r\n27-79,11-45\r\n17-48,18-49\r\n23-86,16-87\r\n61-61,40-60\r\n2-86,1-86\r\n24-73,38-72\r\n14-93,79-89\r\n81-99,62-82\r\n23-56,57-74\r\n42-89,54-90\r\n60-62,7-61\r\n4-80,8-79\r\n3-71,4-70\r\n3-3,4-72\r\n6-44,6-81\r\n26-97,97-98\r\n8-41,41-42\r\n1-99,1-98\r\n26-93,76-93\r\n90-91,16-90\r\n60-78,59-93\r\n57-59,87-97\r\n18-25,25-40\r\n19-97,21-82\r\n79-87,20-88\r\n41-89,40-89\r\n25-80,28-55\r\n4-81,3-92\r\n15-88,15-59\r\n46-79,51-83\r\n52-71,70-95\r\n6-97,6-98\r\n15-91,92-92\r\n22-96,96-97\r\n61-86,85-86\r\n75-94,74-97\r\n67-73,72-86\r\n5-88,6-89\r\n2-70,12-66\r\n13-15,14-30\r\n2-92,1-1\r\n75-97,75-97\r\n55-63,50-63\r\n39-81,76-78\r\n62-86,30-96\r\n44-99,61-86\r\n7-66,7-59\r\n31-47,13-30\r\n40-88,87-89\r\n6-95,96-96\r\n4-89,4-91\r\n8-99,7-99\r\n11-93,10-55\r\n56-58,57-73\r\n1-85,86-86\r\n52-60,52-87\r\n2-98,3-98\r\n1-92,3-26\r\n3-5,4-23\r\n1-99,2-99\r\n15-67,42-96\r\n65-65,62-67\r\n21-21,9-20\r\n54-64,28-53\r\n24-84,51-85\r\n32-95,3-96\r\n4-84,2-97\r\n1-87,1-87\r\n6-88,5-88\r\n48-79,47-62\r\n5-97,4-4\r\n22-46,21-23\r\n4-67,11-47\r\n28-29,29-68\r\n3-68,1-3\r\n6-94,4-4\r\n26-43,26-88\r\n3-46,4-53\r\n88-90,39-89\r\n77-96,50-78\r\n19-83,98-98\r\n4-26,1-82\r\n10-83,82-83\r\n1-2,3-82\r\n22-22,8-21\r\n35-51,34-85\r\n1-99,98-98\r\n20-45,14-21\r\n2-74,1-75\r\n1-5,5-21\r\n14-98,14-99\r\n7-91,9-92\r\n16-51,6-55\r\n27-63,13-63\r\n86-86,54-87\r\n31-96,16-96\r\n25-98,98-99\r\n4-92,4-93\r\n51-81,50-82\r\n18-86,40-85\r\n37-59,25-66\r\n80-97,59-81\r\n2-99,85-98\r\n54-86,55-85\r\n11-39,11-37\r\n11-13,12-62\r\n65-91,98-98\r\n22-38,37-45\r\n8-32,9-32\r\n61-84,83-85\r\n27-72,11-72\r\n90-94,12-90\r\n9-97,9-68\r\n3-95,4-95\r\n73-73,58-74\r\n13-16,12-14\r\n71-89,45-72\r\n44-72,44-73\r\n56-58,57-71\r\n47-53,43-52\r\n50-60,10-49\r\n6-19,20-67\r\n49-88,69-87\r\n48-60,21-70\r\n98-98,85-97\r\n18-18,19-30\r\n50-82,81-82\r\n7-63,8-63\r\n79-96,78-95\r\n4-96,1-1\r\n79-80,1-80\r\n20-78,19-81\r\n26-85,26-27\r\n15-24,15-24\r\n2-80,3-81\r\n5-74,4-4\r\n2-2,3-92\r\n1-87,7-84\r\n84-85,34-85\r\n18-96,18-19\r\n50-52,51-89\r\n82-82,48-82\r\n17-54,18-58\r\n82-96,3-97\r\n20-66,67-94\r\n7-83,8-83\r\n2-2,3-67\r\n2-97,96-99\r\n57-69,70-71\r\n70-83,69-83\r\n37-96,39-42\r\n51-99,50-99\r\n18-90,19-90\r\n76-99,75-88\r\n15-52,6-14\r\n3-94,62-95\r\n60-81,59-59\r\n11-26,11-51\r\n8-92,7-92\r\n31-80,79-81\r\n92-93,3-93\r\n14-35,2-13\r\n31-85,84-85\r\n32-91,32-90\r\n31-61,30-61\r\n18-20,19-48\r\n19-60,20-20\r\n73-97,26-85\r\n31-84,85-85\r\n13-80,12-80\r\n2-83,83-98\r\n13-58,14-57\r\n53-86,22-86\r\n8-76,7-9\r\n28-61,29-62\r\n5-99,4-5\r\n96-98,2-97\r\n4-95,94-94\r\n1-58,6-93\r\n33-62,4-63\r\n18-48,8-14\r\n11-85,86-99\r\n36-58,36-59\r\n48-75,49-96\r\n11-92,91-93\r\n67-77,66-67\r\n13-83,73-82\r\n43-61,60-77\r\n68-90,67-68\r\n89-90,90-90\r\n27-95,26-26\r\n31-31,11-36\r\n9-97,11-95\r\n75-86,76-86\r\n19-19,20-64\r\n99-99,7-97\r\n69-69,69-70\r\n9-99,8-99\r\n83-91,10-92\r\n22-22,21-21\r\n41-67,40-42\r\n2-8,7-61\r\n47-63,46-68";

bool BinomeOverlapse(string binome)
{
    var elfs = binome.Split(',');
    var elf1 = elfs[0].Split('-').Select(s => int.Parse(s)).ToArray();
    var elf2 = elfs[1].Split('-').Select(s => int.Parse(s)).ToArray();

    Range rangeElf1 = new(elf1[0], elf1[1]);
    Range rangeElf2 = new(elf2[0], elf2[1]);

    return ( 
        ((rangeElf1.Start.Value <= rangeElf2.Start.Value) && (rangeElf2.End.Value <= rangeElf1.End.Value)) 
        ||
        ((rangeElf2.Start.Value <= rangeElf1.Start.Value) && (rangeElf1.End.Value <= rangeElf2.End.Value)) 
        );
}

bool BinomeOverlapseV2(string binome)
{
    var elfs = binome.Split(',');
    var elf1 = elfs[0].Split('-').Select(s => int.Parse(s)).ToArray();
    var elf2 = elfs[1].Split('-').Select(s => int.Parse(s)).ToArray();

    var rangeElf1 = Enumerable.Range(elf1[0], elf1[1] - elf1[0] + 1);
    var rangeElf2 = Enumerable.Range(elf2[0], elf2[1] - elf2[0] + 1);

    //foreach (var i in rangeElf1)
    //    Console.Write($"{i} ");
    //Console.WriteLine();
    //Console.WriteLine();
    //foreach (var i in rangeElf2)
    //    Console.Write($"{i} ");
    //Console.WriteLine();
    //Console.WriteLine("-----------");

    return (rangeElf1.Any(i => rangeElf2.Contains(i))) || (rangeElf2.Any(i => rangeElf1.Contains(i)));
}

var result1 = inputs.Split("\r\n").Count(binome => BinomeOverlapse(binome));

Console.WriteLine(result1);

var result2 = inputs.Split("\r\n").Count(binome => BinomeOverlapseV2(binome));

Console.WriteLine(result2);