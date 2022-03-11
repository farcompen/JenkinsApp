pipeline {
    agent any 
    stages {
        stage('Build') {
            steps {
                echo 'Build Starts!'
                bat "\"C:/Program Files/dotnet/dotnet.exe\" restore \"${workspace}/JenkinsFirstApp.sln\""
                bat "\"C:/Program Files/dotnet/dotnet.exe\" build \"${workspace}/JenkinsFirstApp.sln\""
                echo 'Build Ends'
            }
        }
		
		
		
		stage('Deploy') {
            steps {
                echo 'Deploy Starts!'
                bat "\"C:/Program Files/dotnet/dotnet.exe\" publish \"${workspace}/JenkinsFirstApp\" --output \"I:/j2\""
                echo 'Deploy Ends'
            }
        }		
    }
}
