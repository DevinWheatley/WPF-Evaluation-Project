   M S B A M L   `   `   `  ����Q  MWPF Evaluation Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPF_Evaluation_ProjectWPF_Evaluation_Project  5   	   *    $WPF_Evaluation_Project.CreateAccount   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:WPF_Evaluation_Project     5   	     � Title$  Create Account��5   	   $	��450��6    $	��800��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      $��40 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5"   
   �� $$��/resources/images/psg logo.png��6   $��1��68   $��Uniform=�6E   $
��80px��6W   �� 5#   
   $��2��6   $��Center=�6!   $��20(�6>   $��
0,0, 0, 20q�6L   $��Paris Saint Germain��6`   �� 5$   
   $��3��6   $��Center=�6!   $��15(�6>   $��	Username:��6L   �� 5%   
   -   5         ��Name$ inputUsername��5%      $��4��6)   $��Center=�66   $	��200��6S   6a   �� 5&   
   $��5��6   $��Center=�6!   $��15(�6>   $��	Password:��6L   G� 5'   
   -   5         G�Name$ inputPassword��5'      $��6��6-   $��Center=�6:   $	��200��6W   6e   �� 5(   
   $��7��6   $��Center=�6!   $��15(�6>   $��Name:��6L   �� 5)   
   -   5        $ 	inputName��5)      $��8��6%   $��Center=�62   $	��200��6O   6]   �� 5*   
   $��9��6   $��Center=�6!   $��15(�6>   $��Email:��6L   �� 5+   
   -   5        $ 
inputEmail��5+      $��10��6&   $��Center=�64   $	��200��6Q   6_   �� 5,   
   -   5        $��11��5,      $��Center=�68   $
��0,10q�6U   $��5,0,5,3q�6c   .��6u   Create Account6�   �� 5-   
   -   5         ��Name$ DisplayTextBlock��5-      $��Center=�6.   $��10q�6K   6Y   5.      5/      