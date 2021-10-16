
[xml] $csProj = Get-Content ./Assembly-CSharp/Assembly-CSharp.csproj

foreach( $itemGroup in $csProj.Project.ItemGroup )
{
    foreach( $reference in $itemGroup.Reference )
    {
        if( $reference.Include -eq $null )
        {
            continue
        }

        if( $reference.HintPath -eq $null )
        {
                continue
        }
        if( $reference.HintPath.Contains('..\lib\'))
        {
            $path = './lib/';
            if(!(test-path $path))
            {
                New-Item -ItemType Directory -Force -Path $path
            }

            $fullpath = $reference.HintPath.Replace('..\lib\', "${env:ProgramFiles(x86)}\Steam\steamapps\common\OxygenNotIncluded\OxygenNotIncluded_Data\Managed\");
                & xcopy  $fullpath .\lib\ /Y
        }
    }
}


[xml] $csProj = Get-Content ./Assembly-CSharp-firstpass/Assembly-CSharp-firstpass.csproj

foreach( $itemGroup in $csProj.Project.ItemGroup )
{
    foreach( $reference in $itemGroup.Reference )
    {
        if( $reference.Include -eq $null )
        {
            continue
        }

        if( $reference.HintPath -eq $null )
        {
                continue
        }
        if( $reference.HintPath.Contains('..\lib\'))
        {
            $path = './lib/';
            if(!(test-path $path))
            {
                New-Item -ItemType Directory -Force -Path $path
            }

            $fullpath = $reference.HintPath.Replace('..\lib\', "${env:ProgramFiles(x86)}\Steam\steamapps\common\OxygenNotIncluded\OxygenNotIncluded_Data\Managed\");
                & xcopy  $fullpath .\lib\ /Y
        }
    }
}
