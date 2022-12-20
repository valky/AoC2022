﻿using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

var realCave = "493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n465,101 -> 465,103 -> 458,103 -> 458,111 -> 477,111 -> 477,103 -> 469,103 -> 469,101\r\n490,34 -> 494,34\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n493,32 -> 497,32\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n458,132 -> 463,132\r\n473,38 -> 487,38\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n482,76 -> 486,76\r\n451,138 -> 451,141 -> 444,141 -> 444,147 -> 463,147 -> 463,141 -> 455,141 -> 455,138\r\n455,114 -> 455,118 -> 451,118 -> 451,123 -> 459,123 -> 459,118 -> 458,118 -> 458,114\r\n463,165 -> 463,160 -> 463,165 -> 465,165 -> 465,156 -> 465,165 -> 467,165 -> 467,159 -> 467,165 -> 469,165 -> 469,157 -> 469,165 -> 471,165 -> 471,163 -> 471,165 -> 473,165 -> 473,156 -> 473,165\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n469,51 -> 469,42 -> 469,51 -> 471,51 -> 471,42 -> 471,51 -> 473,51 -> 473,43 -> 473,51\r\n490,26 -> 494,26\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n463,165 -> 463,160 -> 463,165 -> 465,165 -> 465,156 -> 465,165 -> 467,165 -> 467,159 -> 467,165 -> 469,165 -> 469,157 -> 469,165 -> 471,165 -> 471,163 -> 471,165 -> 473,165 -> 473,156 -> 473,165\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n463,165 -> 463,160 -> 463,165 -> 465,165 -> 465,156 -> 465,165 -> 467,165 -> 467,159 -> 467,165 -> 469,165 -> 469,157 -> 469,165 -> 471,165 -> 471,163 -> 471,165 -> 473,165 -> 473,156 -> 473,165\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n451,138 -> 451,141 -> 444,141 -> 444,147 -> 463,147 -> 463,141 -> 455,141 -> 455,138\r\n469,171 -> 473,171\r\n469,51 -> 469,42 -> 469,51 -> 471,51 -> 471,42 -> 471,51 -> 473,51 -> 473,43 -> 473,51\r\n463,165 -> 463,160 -> 463,165 -> 465,165 -> 465,156 -> 465,165 -> 467,165 -> 467,159 -> 467,165 -> 469,165 -> 469,157 -> 469,165 -> 471,165 -> 471,163 -> 471,165 -> 473,165 -> 473,156 -> 473,165\r\n465,101 -> 465,103 -> 458,103 -> 458,111 -> 477,111 -> 477,103 -> 469,103 -> 469,101\r\n487,32 -> 491,32\r\n472,168 -> 476,168\r\n496,30 -> 500,30\r\n455,114 -> 455,118 -> 451,118 -> 451,123 -> 459,123 -> 459,118 -> 458,118 -> 458,114\r\n459,151 -> 459,152 -> 468,152 -> 468,151\r\n451,138 -> 451,141 -> 444,141 -> 444,147 -> 463,147 -> 463,141 -> 455,141 -> 455,138\r\n459,151 -> 459,152 -> 468,152 -> 468,151\r\n496,34 -> 500,34\r\n484,30 -> 488,30\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n451,132 -> 456,132\r\n463,165 -> 463,160 -> 463,165 -> 465,165 -> 465,156 -> 465,165 -> 467,165 -> 467,159 -> 467,165 -> 469,165 -> 469,157 -> 469,165 -> 471,165 -> 471,163 -> 471,165 -> 473,165 -> 473,156 -> 473,165\r\n490,30 -> 494,30\r\n455,114 -> 455,118 -> 451,118 -> 451,123 -> 459,123 -> 459,118 -> 458,118 -> 458,114\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n461,129 -> 466,129\r\n472,72 -> 472,73 -> 483,73 -> 483,72\r\n481,32 -> 485,32\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n476,82 -> 480,82\r\n454,129 -> 459,129\r\n463,165 -> 463,160 -> 463,165 -> 465,165 -> 465,156 -> 465,165 -> 467,165 -> 467,159 -> 467,165 -> 469,165 -> 469,157 -> 469,165 -> 471,165 -> 471,163 -> 471,165 -> 473,165 -> 473,156 -> 473,165\r\n470,88 -> 470,92 -> 469,92 -> 469,98 -> 483,98 -> 483,92 -> 475,92 -> 475,88\r\n465,101 -> 465,103 -> 458,103 -> 458,111 -> 477,111 -> 477,103 -> 469,103 -> 469,101\r\n463,165 -> 463,160 -> 463,165 -> 465,165 -> 465,156 -> 465,165 -> 467,165 -> 467,159 -> 467,165 -> 469,165 -> 469,157 -> 469,165 -> 471,165 -> 471,163 -> 471,165 -> 473,165 -> 473,156 -> 473,165\r\n463,165 -> 463,160 -> 463,165 -> 465,165 -> 465,156 -> 465,165 -> 467,165 -> 467,159 -> 467,165 -> 469,165 -> 469,157 -> 469,165 -> 471,165 -> 471,163 -> 471,165 -> 473,165 -> 473,156 -> 473,165\r\n488,82 -> 492,82\r\n487,28 -> 491,28\r\n470,88 -> 470,92 -> 469,92 -> 469,98 -> 483,98 -> 483,92 -> 475,92 -> 475,88\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n469,51 -> 469,42 -> 469,51 -> 471,51 -> 471,42 -> 471,51 -> 473,51 -> 473,43 -> 473,51\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n463,165 -> 463,160 -> 463,165 -> 465,165 -> 465,156 -> 465,165 -> 467,165 -> 467,159 -> 467,165 -> 469,165 -> 469,157 -> 469,165 -> 471,165 -> 471,163 -> 471,165 -> 473,165 -> 473,156 -> 473,165\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n463,165 -> 463,160 -> 463,165 -> 465,165 -> 465,156 -> 465,165 -> 467,165 -> 467,159 -> 467,165 -> 469,165 -> 469,157 -> 469,165 -> 471,165 -> 471,163 -> 471,165 -> 473,165 -> 473,156 -> 473,165\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n473,54 -> 481,54 -> 481,53\r\n485,79 -> 489,79\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n479,85 -> 483,85\r\n463,177 -> 467,177\r\n455,114 -> 455,118 -> 451,118 -> 451,123 -> 459,123 -> 459,118 -> 458,118 -> 458,114\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n462,135 -> 467,135\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n470,88 -> 470,92 -> 469,92 -> 469,98 -> 483,98 -> 483,92 -> 475,92 -> 475,88\r\n472,174 -> 476,174\r\n469,135 -> 474,135\r\n478,34 -> 482,34\r\n479,79 -> 483,79\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n463,165 -> 463,160 -> 463,165 -> 465,165 -> 465,156 -> 465,165 -> 467,165 -> 467,159 -> 467,165 -> 469,165 -> 469,157 -> 469,165 -> 471,165 -> 471,163 -> 471,165 -> 473,165 -> 473,156 -> 473,165\r\n465,132 -> 470,132\r\n470,88 -> 470,92 -> 469,92 -> 469,98 -> 483,98 -> 483,92 -> 475,92 -> 475,88\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n470,88 -> 470,92 -> 469,92 -> 469,98 -> 483,98 -> 483,92 -> 475,92 -> 475,88\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n469,51 -> 469,42 -> 469,51 -> 471,51 -> 471,42 -> 471,51 -> 473,51 -> 473,43 -> 473,51\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n451,138 -> 451,141 -> 444,141 -> 444,147 -> 463,147 -> 463,141 -> 455,141 -> 455,138\r\n448,135 -> 453,135\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n482,82 -> 486,82\r\n465,101 -> 465,103 -> 458,103 -> 458,111 -> 477,111 -> 477,103 -> 469,103 -> 469,101\r\n484,34 -> 488,34\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n473,54 -> 481,54 -> 481,53\r\n469,51 -> 469,42 -> 469,51 -> 471,51 -> 471,42 -> 471,51 -> 473,51 -> 473,43 -> 473,51\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n463,165 -> 463,160 -> 463,165 -> 465,165 -> 465,156 -> 465,165 -> 467,165 -> 467,159 -> 467,165 -> 469,165 -> 469,157 -> 469,165 -> 471,165 -> 471,163 -> 471,165 -> 473,165 -> 473,156 -> 473,165\r\n463,165 -> 463,160 -> 463,165 -> 465,165 -> 465,156 -> 465,165 -> 467,165 -> 467,159 -> 467,165 -> 469,165 -> 469,157 -> 469,165 -> 471,165 -> 471,163 -> 471,165 -> 473,165 -> 473,156 -> 473,165\r\n457,126 -> 462,126\r\n475,177 -> 479,177\r\n455,114 -> 455,118 -> 451,118 -> 451,123 -> 459,123 -> 459,118 -> 458,118 -> 458,114\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n451,138 -> 451,141 -> 444,141 -> 444,147 -> 463,147 -> 463,141 -> 455,141 -> 455,138\r\n478,174 -> 482,174\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n472,72 -> 472,73 -> 483,73 -> 483,72\r\n469,51 -> 469,42 -> 469,51 -> 471,51 -> 471,42 -> 471,51 -> 473,51 -> 473,43 -> 473,51\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n499,32 -> 503,32\r\n463,165 -> 463,160 -> 463,165 -> 465,165 -> 465,156 -> 465,165 -> 467,165 -> 467,159 -> 467,165 -> 469,165 -> 469,157 -> 469,165 -> 471,165 -> 471,163 -> 471,165 -> 473,165 -> 473,156 -> 473,165\r\n465,101 -> 465,103 -> 458,103 -> 458,111 -> 477,111 -> 477,103 -> 469,103 -> 469,101\r\n463,165 -> 463,160 -> 463,165 -> 465,165 -> 465,156 -> 465,165 -> 467,165 -> 467,159 -> 467,165 -> 469,165 -> 469,157 -> 469,165 -> 471,165 -> 471,163 -> 471,165 -> 473,165 -> 473,156 -> 473,165\r\n481,177 -> 485,177\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n455,135 -> 460,135\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n472,72 -> 472,73 -> 483,73 -> 483,72\r\n463,67 -> 463,57 -> 463,67 -> 465,67 -> 465,64 -> 465,67 -> 467,67 -> 467,64 -> 467,67 -> 469,67 -> 469,57 -> 469,67 -> 471,67 -> 471,62 -> 471,67 -> 473,67 -> 473,57 -> 473,67 -> 475,67 -> 475,65 -> 475,67 -> 477,67 -> 477,57 -> 477,67 -> 479,67 -> 479,58 -> 479,67\r\n470,88 -> 470,92 -> 469,92 -> 469,98 -> 483,98 -> 483,92 -> 475,92 -> 475,88\r\n502,34 -> 506,34\r\n465,101 -> 465,103 -> 458,103 -> 458,111 -> 477,111 -> 477,103 -> 469,103 -> 469,101\r\n451,138 -> 451,141 -> 444,141 -> 444,147 -> 463,147 -> 463,141 -> 455,141 -> 455,138\r\n469,51 -> 469,42 -> 469,51 -> 471,51 -> 471,42 -> 471,51 -> 473,51 -> 473,43 -> 473,51\r\n485,85 -> 489,85\r\n475,171 -> 479,171\r\n459,151 -> 459,152 -> 468,152 -> 468,151\r\n491,85 -> 495,85\r\n463,165 -> 463,160 -> 463,165 -> 465,165 -> 465,156 -> 465,165 -> 467,165 -> 467,159 -> 467,165 -> 469,165 -> 469,157 -> 469,165 -> 471,165 -> 471,163 -> 471,165 -> 473,165 -> 473,156 -> 473,165\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n469,51 -> 469,42 -> 469,51 -> 471,51 -> 471,42 -> 471,51 -> 473,51 -> 473,43 -> 473,51\r\n463,165 -> 463,160 -> 463,165 -> 465,165 -> 465,156 -> 465,165 -> 467,165 -> 467,159 -> 467,165 -> 469,165 -> 469,157 -> 469,165 -> 471,165 -> 471,163 -> 471,165 -> 473,165 -> 473,156 -> 473,165\r\n465,101 -> 465,103 -> 458,103 -> 458,111 -> 477,111 -> 477,103 -> 469,103 -> 469,101\r\n470,88 -> 470,92 -> 469,92 -> 469,98 -> 483,98 -> 483,92 -> 475,92 -> 475,88\r\n493,28 -> 497,28\r\n473,85 -> 477,85\r\n493,23 -> 493,20 -> 493,23 -> 495,23 -> 495,22 -> 495,23 -> 497,23 -> 497,13 -> 497,23 -> 499,23 -> 499,21 -> 499,23 -> 501,23 -> 501,20 -> 501,23 -> 503,23 -> 503,13 -> 503,23 -> 505,23 -> 505,16 -> 505,23\r\n455,114 -> 455,118 -> 451,118 -> 451,123 -> 459,123 -> 459,118 -> 458,118 -> 458,114\r\n455,114 -> 455,118 -> 451,118 -> 451,123 -> 459,123 -> 459,118 -> 458,118 -> 458,114\r\n469,177 -> 473,177\r\n451,138 -> 451,141 -> 444,141 -> 444,147 -> 463,147 -> 463,141 -> 455,141 -> 455,138\r\n466,174 -> 470,174";
var testCave = "498,4 -> 498,6 -> 496,6\r\n503,4 -> 502,4 -> 502,9 -> 494,9";


var scanTest = new Scan(testCave);
scanTest.SimulateSandDrops();


var scanP1 = new Scan(realCave);
scanP1.SimulateSandDrops();
scanP1.DrawCave();


Console.WriteLine($"Test : {scanTest.CaveScan.Sands.Count() - 1}");

Console.WriteLine($"RealP1 : {scanP1.CaveScan.Sands.Count() - 1}");

internal record Point(int X, int Y);

internal enum TypeOfPoint
{ 
    Air,
    Rock,
    Sand,
    SandStart,
}

internal enum Direction
{ 
    Down,
    Left,
    Right,
}

internal class Cave
{
    internal Tuple<Point , Point> Size;

    private readonly List<Rock> Rocks;
    internal List<Point> Sands = new List<Point>();


    internal Cave(List<Rock> rocks)
    {
        Rocks = rocks;

        int XMin = this.Rocks.Min(r => r.Path.Min(p => p.X));
        int YMin = this.Rocks.Min(r => r.Path.Min(p => p.Y));

        int XMax = this.Rocks.Max(r => r.Path.Max(p => p.X));
        int YMax = this.Rocks.Max(r => r.Path.Max(p => p.Y));

        Size = new(new(XMin, YMin), new(XMax, YMax));
    }

    internal TypeOfPoint AnalysePoint(Point point)
        => point switch
        {
            Point p when p.X == 500 && p.Y == 0 => TypeOfPoint.SandStart,
            Point p when IsRock(p) => TypeOfPoint.Rock,
            Point p when IsSand(p) => TypeOfPoint.Sand,
            _ => TypeOfPoint.Air,
        };

    private bool IsRock(Point point)
        => Rocks.Select(r => r.IsInPath(point)).Aggregate((a, b) => a || b);

    private bool IsSand(Point point)
        => Sands.Any(s => s.X == point.X && s.Y == point.Y);
}

internal class Rock
{
    internal readonly List<Point> Path;

    internal Rock(List<Point> points)
    {
        Path = points;
    }

    internal bool IsInPath(Point point)
        => this.Path
            .Skip(1)
            .Zip(this.Path, (start, end) => (start: start, end: end))
            .Any(p =>
                Math.Min(p.start.X, p.end.X) <= point.X && point.X <= Math.Max(p.start.X, p.end.X)
                &&
                Math.Min(p.start.Y, p.end.Y) <= point.Y && point.Y <= Math.Max(p.start.Y, p.end.Y)
        );
}


internal class Scan
{
    internal readonly Cave CaveScan;

    internal Scan(string input)
    {
        CaveScan = ParseInputs(input);
    }

    internal void DrawCave()
    {
        var (startPoint, endPoint) = CaveScan.Size;

        int XMin = startPoint.X;
        int YMin = startPoint.Y;

        int XMax = endPoint.X;
        int YMax = endPoint.Y;

        char GetCharForPoint(Point point)
            => CaveScan.AnalysePoint(point) switch
            {
                TypeOfPoint.Air => '.',
                TypeOfPoint.Sand => '0',
                TypeOfPoint.Rock => '#',
                TypeOfPoint.SandStart => '+',
                _ => throw new Exception("oh non! j'ai du sable dans ma Schlâp!!!!!")
            };

        var sb = new StringBuilder();
        foreach (var y in Enumerable.Range(0, YMax + 2))
        {
            foreach (var x in Enumerable.Range(XMin - 1 , XMax - XMin  + 3))
            {
                sb.Append(GetCharForPoint(new(x, y)));
            }
            sb.AppendLine();
        }

        Console.Write(sb.ToString());
    }

    internal void SimulateSandDrops()
    {
        var endPoint = new Point(500, 0);

        do
        {
            endPoint = SimulateSandDrop();
            CaveScan.Sands.Add(endPoint);
        }
        while ( endPoint.Y < CaveScan.Size.Item2.Y  && endPoint.Y != 0);
    }

    private Point SimulateSandDrop()
    { 
        var sand = new Point(500, 0);

        bool fall = true;
        do
        {
            var nextPoint = GetNextPoint(sand, Direction.Down);
            sand = nextPoint == null ? sand : nextPoint;
            fall = nextPoint != null;
        }
        while (fall);

        return sand;
    }

    private Rock ParseRock(string inputs)
    => new Rock(inputs.Split(" -> ").Select(i => ParsePoint(i)).ToList());

    private Cave ParseInputs(string inputs)
        => new Cave(inputs.Split("\r\n").Select(i => ParseRock(i)).ToList());

    private Point ParsePoint(string inputs)
        => new Point(int.Parse(inputs.Split(",")[0]), int.Parse(inputs.Split(",")[1]));

    private bool CanMoveTo(Point destination)
        => CaveScan.AnalysePoint(destination) switch
        {
            TypeOfPoint.Air => true,
            TypeOfPoint.SandStart => true,
            TypeOfPoint.Rock => false,
            TypeOfPoint.Sand => false,
            _ => throw new Exception("Meme un grain de sable peux bloquer une rolex"),
        };

    private Point GetNewPoint(Point point, Direction direction)
        => direction switch
        {
            Direction.Down => new Point(point.X, point.Y + 1),
            Direction.Left => new Point(point.X - 1, point.Y + 1),
            Direction.Right => new Point(point.X + 1, point.Y + 1),
            _ => throw new Exception("Faut arrêter ces conneries de nord et de sud ! Une fois pour toutes, le nord, suivant comment on est tourné, ça change tout !"),
        };

    private Point? GetNextPoint(Point point, Direction direction)
        => CanMoveTo(GetNewPoint(point, direction)) switch
        {
            true when point.Y > CaveScan.Size.Item2.Y => null,
            true  => GetNewPoint(point, direction),
            false when direction == Direction.Down => GetNextPoint(point, Direction.Left),
            false when direction == Direction.Left => GetNextPoint(point, Direction.Right),
            false when direction == Direction.Right => null,
            _ => throw new Exception("Cette affirmation est fausse!"),
        };

}


